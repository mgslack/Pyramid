using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Checkers;

/*
 * Partical class containing the definition of the options dialog for the Pyramid
 * game.
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
    public partial class OptionsDlg : Form
    {
        #region Properties
        private CheckerImages _images = null;
        public CheckerImages Images { set => _images = value; }

        public CheckerColors CheckerColor { get; set; }

        public Color SquareColor { get; set; }
        #endregion

        // --------------------------------------------------------------------

        public OptionsDlg()
        {
            InitializeComponent();
        }

        // --------------------------------------------------------------------

        #region Private Methods
        /*
         * Magnus - 2011-02-23 (stackoverflow.com / Web Color List in C# application)
         */
        private IOrderedEnumerable<Color> GetWebColors()
        {
            return Enum.GetValues(typeof(KnownColor))
                .Cast<KnownColor>()
                .Where(k => k > KnownColor.Transparent && k < KnownColor.ButtonFace) //Exclude system colors
                .Select(k => Color.FromKnownColor(k))
                .OrderBy(c => c.GetHue())
                .ThenBy(c => c.GetSaturation())
                .ThenBy(c => c.GetBrightness());
        }
        #endregion

        // --------------------------------------------------------------------

        #region Event Handlers
        private void OptionsDlg_Load(object sender, EventArgs e)
        {
            int sqr = 0, idx = 0;

            foreach (string name in Enum.GetNames(typeof(CheckerColors)))
                cbCheckerColor.Items.Add(name);
            cbCheckerColor.SelectedIndex = (int)CheckerColor;
            if (_images != null) pbChecker.Image = _images.GetCheckerImage(CheckerColor);

            foreach (Color col in GetWebColors())
            {
                string name = Enum.GetName(typeof(KnownColor), col.ToKnownColor());
                cbSqColor.Items.Add(name);
                if (col.ToKnownColor() == SquareColor.ToKnownColor()) sqr = idx;
                idx++;
            }
            cbSqColor.SelectedIndex = sqr;
            psSqr.BackColor = SquareColor;
        }

        private void CbCheckerColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckerColor = (CheckerColors)cbCheckerColor.SelectedIndex;
            if (_images != null) pbChecker.Image = _images.GetCheckerImage(CheckerColor);
        }

        private void CbSqColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = (string)cbSqColor.Items[cbSqColor.SelectedIndex];
            SquareColor = Color.FromName(name);
            psSqr.BackColor = SquareColor;
        }

        private void BtnDefaults_Click(object sender, EventArgs e)
        {
            cbCheckerColor.SelectedIndex = (int)CheckerColors.Black;
            CbCheckerColor_SelectedIndexChanged(sender, e);
            cbSqColor.SelectedIndex = cbSqColor.Items.IndexOf(Color.Red.Name);
            CbSqColor_SelectedIndexChanged(sender, e);
        }
        #endregion
    }
}
