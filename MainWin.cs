using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Reflection;
using System.IO;
using System.Diagnostics;
using Checkers;
using GameStatistics;

/*
 * Partial class defining the Pyramid game main window.  This game of Pyramid is based on a game
 * idea created by Clinton Pasfield, March 1994 and published in the Delphi SWAG archive.
 * 
 * Author: Michael Slack
 * Date Written: 2021-11-20
 * 
 * ----------------------------------------------------------------------------
 * 
 * Revised: yyyy-mm-dd - xxxx.
 * 
 */
namespace Pyramid
{
    public partial class MainWin : Form
    {
        #region Private consts/statics
        private const string HTML_HELP_FILE = "Pyramid_help.html";
        private const int MAX_SQUARES = 15;
        private const int MAX_MOVES = 36;
        private const int FROM = 0;
        private const int OVER = 1;
        private const int TO = 2;
        // idx from, over, to
        private static readonly int[,] VALID_MOVES = {{0, 1, 3},  {0, 2, 5},
                                                      {1, 3, 6},  {1, 4, 8},
                                                      {2, 4, 7},  {2, 5, 9},
                                                      {3, 1, 0},  {3, 4, 5}, {3, 6, 10}, {3, 7, 12},
                                                      {4, 7, 11}, {4, 8, 13},
                                                      {5, 2, 0},  {5, 4, 3}, {5, 8, 12}, {5, 9, 14},
                                                      {6, 3, 1},  {6, 7, 8},
                                                      {7, 4, 2},  {7, 8, 9},
                                                      {8, 4, 1},  {8, 7, 6},
                                                      {9, 5, 2},  {9, 8, 7},
                                                      {10, 6, 3}, {10, 11, 12},
                                                      {11, 7, 4}, {11, 12, 13},
                                                      {12, 7, 3}, {12, 8, 5}, {12, 11, 10}, {12, 13, 14},
                                                      {13, 8, 4}, {13, 12, 11},
                                                      {14, 9, 5}, {14, 13, 12}};
        #endregion

        #region Registry Constants
        private const string REG_NAME = @"HKEY_CURRENT_USER\Software\Slack and Associates\Games\Pyramid";
        private const string REG_KEY1 = "PosX";
        private const string REG_KEY2 = "PosY";
        private const string REG_KEY3 = "CheckerColor";
        private const string REG_KEY4 = "BoardSquareColor";
        #endregion

        #region Private vars
        private CheckerColors checkerColor = CheckerColors.Black;
        private Color squareColor = Color.Red;
        private CheckerImages images = new CheckerImages();
        private PyramidSquare[] PyramidBoard = new PyramidSquare[MAX_SQUARES];
        private Statistics stats = new Statistics(REG_NAME);
        private Stack<int[]> undoStack = new Stack<int[]>();
        #endregion

        #region Drag-n-Drop vars
        private Bitmap origDragImage = null;
        private bool useCustomCursors = false;
        private bool dragStarting = false;
        private int dragStartLoc = 0;
        private Cursor checkerMoveCursor = null;
        private Cursor checkerNoneCursor = null;
        #endregion

        // --------------------------------------------------------------------

        #region Private methods
        private void InitPyramidBoard()
        {
            PyramidBoard[0] = pyramidSquare1; PyramidBoard[1] = pyramidSquare2;
            PyramidBoard[2] = pyramidSquare3; PyramidBoard[3] = pyramidSquare4;
            PyramidBoard[4] = pyramidSquare5; PyramidBoard[5] = pyramidSquare6;
            PyramidBoard[6] = pyramidSquare7; PyramidBoard[7] = pyramidSquare8;
            PyramidBoard[8] = pyramidSquare9; PyramidBoard[9] = pyramidSquare10;
            PyramidBoard[10] = pyramidSquare11; PyramidBoard[11] = pyramidSquare12;
            PyramidBoard[12] = pyramidSquare13; PyramidBoard[13] = pyramidSquare14;
            PyramidBoard[14] = pyramidSquare15;
            for (int i = 0; i < MAX_SQUARES; i++) PyramidBoard[i].AssignDragDropEvents(this);
            checkerNoneCursor = CursorUtil.CreateCursor(images.GetDisabledChecker(), 24, 24);
        }

        private void LoadRegistryValues()
        {
            int winX = -1, winY = -1;
            KnownColor sqr = squareColor.ToKnownColor();

            try
            {
                winX = (int)Registry.GetValue(REG_NAME, REG_KEY1, winX);
                winY = (int)Registry.GetValue(REG_NAME, REG_KEY2, winY);
                checkerColor = (CheckerColors)Registry.GetValue(REG_NAME, REG_KEY3, (int)checkerColor);
                sqr = (KnownColor)Registry.GetValue(REG_NAME, REG_KEY4, (int)sqr);
            }
            catch (Exception) { /* ignore, go with defaults */ }

            if ((winX != -1) && (winY != -1)) this.SetDesktopLocation(winX, winY);
            squareColor = Color.FromKnownColor(sqr);
            if (squareColor != Color.Red)
                for (int i = 0; i < MAX_SQUARES; i++) PyramidBoard[i].BackColor = squareColor;
        }

        private void WriteRegistryValues()
        {
            Registry.SetValue(REG_NAME, REG_KEY3, (int)checkerColor);
            Registry.SetValue(REG_NAME, REG_KEY4, (int)squareColor.ToKnownColor());
        }

        private void SetupContextMenu()
        {
            ContextMenu mnu = new ContextMenu();
            MenuItem mnuStats = new MenuItem("Game Statistics");
            MenuItem sep = new MenuItem("-");
            MenuItem mnuAbout = new MenuItem("About");

            mnuStats.Click += new EventHandler(MnuStats_Click);
            mnuAbout.Click += new EventHandler(MnuAbout_Click);
            mnu.MenuItems.AddRange(new MenuItem[] { mnuStats, sep, mnuAbout });
            this.ContextMenu = mnu;
        }

        private void GenerateNewGame()
        {
            Random rnd = new Random();
            int openIdx = rnd.Next(MAX_SQUARES);

            for (int i = 0; i < MAX_SQUARES; i++)
                if (i != openIdx)
                    PyramidBoard[i].Image = images.GetCheckerImage(checkerColor);
                else
                    PyramidBoard[i].Image = null; // clear it, already played game, starting new...
        }

        private void CheckGameOver()
        {
            bool moreMoves = false, gameWon = false;
            int numCheckers = 0;

            for (int i = 0; i < MAX_SQUARES; i++)
                if (PyramidBoard[i].Image != null) numCheckers++;
            if (numCheckers == 1) gameWon = true;

            if (!gameWon)
            {
                for (int i = 0; i < MAX_MOVES; i++)
                {
                    if (PyramidBoard[VALID_MOVES[i, FROM]].Image != null)
                    {
                        moreMoves = (PyramidBoard[VALID_MOVES[i, OVER]].Image != null &&
                            PyramidBoard[VALID_MOVES[i, TO]].Image == null);
                        if (moreMoves) i = MAX_MOVES;
                    }
                }
                if (!moreMoves)
                {
                    DialogResult res = MessageBox.Show(this, 
                        "No more moves possible, undo last move to try again? (yes=undo, no=end game)",
                        this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);
                    if (res == DialogResult.Yes)
                    {
                        BtnUndo_Click(this, EventArgs.Empty); moreMoves = true;
                    }
                    else
                    {
                        stats.GameLost(0);
                    }
                }
            }
            else
            {
                MessageBox.Show("Congratulations, You've won the game.", this.Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                stats.GameWon(0);
            }
            if (!gameWon && !moreMoves)
            {
                btnStart.Enabled = true; undoStack.Clear(); btnUndo.Enabled = false;
            }
        }
        #endregion

        // --------------------------------------------------------------------

        public MainWin()
        {
            InitializeComponent();
        }

        // --------------------------------------------------------------------

        #region Event Handlers
        private void MainWin_Load(object sender, EventArgs e)
        {
            InitPyramidBoard();
            LoadRegistryValues();
            SetupContextMenu();
            stats.GameName = this.Text;
        }

        private void MainWin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                Registry.SetValue(REG_NAME, REG_KEY1, this.Location.X);
                Registry.SetValue(REG_NAME, REG_KEY2, this.Location.Y);
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            GenerateNewGame();
            stats.StartGame(true);
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            int[] undo = undoStack.Pop();

            PyramidBoard[undo[FROM]].Image = PyramidBoard[undo[TO]].Image;
            PyramidBoard[undo[TO]].Image = null;
            PyramidBoard[undo[OVER]].Image = images.GetCheckerImage(checkerColor);

            btnUndo.Enabled = undoStack.Count > 0;
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnOptions_Click(object sender, EventArgs e)
        {
            OptionsDlg dlg = new OptionsDlg
            { 
                Images = images,
                CheckerColor = checkerColor,
                SquareColor = squareColor
            };

            DialogResult res = dlg.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                bool redraw = false;

                if (checkerColor != dlg.CheckerColor) { checkerColor = dlg.CheckerColor; redraw = true; }
                if (squareColor != dlg.SquareColor) { squareColor = dlg.SquareColor; redraw = true; }
                if (redraw)
                {
                    for (int i = 0; i < MAX_SQUARES; i++)
                    {
                        if (PyramidBoard[i].Image != null)
                            PyramidBoard[i].Image = images.GetCheckerImage(checkerColor);
                        PyramidBoard[i].BackColor = squareColor;
                    }
                    WriteRegistryValues();
                }
            }
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            var asm = Assembly.GetEntryAssembly();
            var asmLocation = Path.GetDirectoryName(asm.Location);
            var htmlPath = Path.Combine(asmLocation, HTML_HELP_FILE);

            try
            {
                Process.Start(htmlPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot load help: " + ex.Message, "Help Load Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MnuStats_Click(object sender, EventArgs e)
        {
            stats.ShowStatistics(this);
        }

        private void MnuAbout_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();

            about.ShowDialog(this);
            about.Dispose();
        }
        #endregion

        // --------------------------------------------------------------------

        #region Drag-n-Drop methods
        private void DragCreateCursor(int location)
        {
            Bitmap piece = PyramidBoard[location].Image;

            if (piece != null)
            {
                checkerMoveCursor = CursorUtil.CreateCursor(piece, piece.Width / 2, piece.Height / 2);
            }
            useCustomCursors = ((checkerMoveCursor != null) && (checkerNoneCursor != null));
        }

        private void DragDisposeCursor()
        {
            useCustomCursors = false;
            if (checkerMoveCursor != null) checkerMoveCursor.Dispose();
        }

        private void DragMoveComplete()
        {
            // don't need...
        }

        public void MainWin_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is PyramidSquare && e.Button != MouseButtons.Right)
            {
                int loc = (sender as PyramidSquare).PyramidLocationIndex;
                origDragImage = PyramidBoard[loc].Image;
                if (origDragImage != null)
                {
                    dragStartLoc = loc;
                    DragCreateCursor(loc);
                    dragStarting = true;
                    if (DoDragDrop(origDragImage, DragDropEffects.Move) == DragDropEffects.Move)
                    {
                        DragMoveComplete();
                    }
                    else
                    {
                        DragDisposeCursor();
                        PyramidBoard[dragStartLoc].Image = origDragImage;
                    }
                }
            }
        }

        public void MainWin_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            if (useCustomCursors)
            {
                // Sets the custom cursor based upon the effect.
                e.UseDefaultCursors = false;
                if ((e.Effect & DragDropEffects.Move) == DragDropEffects.Move)
                    Cursor.Current = checkerMoveCursor;
                else
                    Cursor.Current = checkerNoneCursor;
                if (dragStarting)
                {
                    // remove checker from start loc
                    PyramidBoard[dragStartLoc].Image = null;
                    dragStarting = false;
                }
            }
            else
                e.UseDefaultCursors = true;
        }

        private bool CanDragTo(int currentLoc)
        {
            bool can = false;

            for (int i = 0; i < MAX_MOVES; i++)
            {
                // if starting loc is valid to move to current location and it is empty
                // and jump location has checker, can drag to currentloc
                if (VALID_MOVES[i, FROM] == dragStartLoc && VALID_MOVES[i, TO] == currentLoc)
                {
                    can = (PyramidBoard[currentLoc].Image == null &&
                        PyramidBoard[VALID_MOVES[i, OVER]].Image != null);
                }
            }

            return can;
        }

        public void MainWin_DragEnter(object sender, DragEventArgs e)
        {
            if (sender is PyramidSquare)
            {
                int loc = (sender as PyramidSquare).PyramidLocationIndex;
                if (CanDragTo(loc))
                    e.Effect = DragDropEffects.Move;
                else
                    e.Effect = DragDropEffects.None;
            }
        }

        public void MainWin_DragDrop(object sender, DragEventArgs e)
        {
            if (sender is PyramidSquare)
            {
                int dragEndLoc = (sender as PyramidSquare).PyramidLocationIndex;
                PyramidBoard[dragEndLoc].Image = origDragImage;
                for (int i = 0; i < MAX_MOVES; i++)
                {
                    if (VALID_MOVES[i, FROM] == dragStartLoc && VALID_MOVES[i, TO] == dragEndLoc)
                    {
                        PyramidBoard[VALID_MOVES[i, OVER]].Image = null;
                        int[] undo = new int[3];
                        for (int j = 0; j < 3; j++) undo[j] = VALID_MOVES[i, j];
                        undoStack.Push(undo);
                        btnUndo.Enabled = undoStack.Count > 0;
                    }
                }
                stats.MoveMade();
                CheckGameOver();
            }
        }
        #endregion
    }
}
