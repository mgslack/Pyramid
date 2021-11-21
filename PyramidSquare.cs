using System.Drawing;
using System.Windows.Forms;

/*
 * Control implementing a square (checker) location for the Pyramid game.  This control
 * was designed for and should only be use by the Pyramid form.  Has the pyramid location
 * index as a property, will be between 0 and 14.
 * If image is set, will draw it on the square, centered, if possible.
 * 
 * Author: Michael Slack
 * Date Written: 2021-11-19
 * 
 * ----------------------------------------------------------------------------
 * 
 * Revised: yyyy-mm-dd - xxxx.
 * 
 */
namespace Pyramid
{
    public partial class PyramidSquare : UserControl
    {
        #region Private consts
        private const int MIN_IDX = 0;
        private const int MAX_IDX = 14;
        #endregion

        #region Properties
        private int _pyramidLocation = 0;
        public int PyramidLocationIndex {
            get => _pyramidLocation;
            set { if (value >= MIN_IDX && value <= MAX_IDX) _pyramidLocation = value; }
        }

        private Bitmap _image = null;
        public Bitmap Image { get => _image; set { _image = value; this.Invalidate(); } }
        #endregion

        // --------------------------------------------------------------------

        public PyramidSquare()
        {
            InitializeComponent();
        }

        // --------------------------------------------------------------------

        #region Overrides
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = e.Graphics;

            if (_image != null)
            {
                int x = 0, y = 0;

                if (_image.Width < this.Width) x = (this.Width - _image.Width) / 2;
                if (_image.Height < this.Height) y = (this.Height - _image.Height) / 2;

                graphics.DrawImage(_image, new Point(x, y));
            }
        }
        #endregion

        // --------------------------------------------------------------------

        #region Public methods
        public void AssignDragDropEvents(Form parent)
        {
            AllowDrop = true;
            this.MouseDown += ((MainWin)parent).MainWin_MouseDown;
            this.GiveFeedback += ((MainWin)parent).MainWin_GiveFeedback;
            this.DragEnter += ((MainWin)parent).MainWin_DragEnter;
            this.DragDrop += ((MainWin)parent).MainWin_DragDrop;
        }
        #endregion
    }
}
