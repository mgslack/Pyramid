
namespace Pyramid
{
    partial class OptionsDlg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbCheckerColor = new System.Windows.Forms.ComboBox();
            this.pbChecker = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSqColor = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDefaults = new System.Windows.Forms.Button();
            this.psSqr = new Pyramid.PyramidSquare();
            ((System.ComponentModel.ISupportInitialize)(this.pbChecker)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Checker Color:";
            // 
            // cbCheckerColor
            // 
            this.cbCheckerColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCheckerColor.FormattingEnabled = true;
            this.cbCheckerColor.Location = new System.Drawing.Point(12, 25);
            this.cbCheckerColor.Name = "cbCheckerColor";
            this.cbCheckerColor.Size = new System.Drawing.Size(130, 21);
            this.cbCheckerColor.TabIndex = 1;
            this.cbCheckerColor.SelectedIndexChanged += new System.EventHandler(this.CbCheckerColor_SelectedIndexChanged);
            // 
            // pbChecker
            // 
            this.pbChecker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbChecker.Location = new System.Drawing.Point(148, 9);
            this.pbChecker.Name = "pbChecker";
            this.pbChecker.Size = new System.Drawing.Size(51, 51);
            this.pbChecker.TabIndex = 2;
            this.pbChecker.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "&Pyramid Square Color:";
            // 
            // cbSqColor
            // 
            this.cbSqColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSqColor.FormattingEnabled = true;
            this.cbSqColor.Location = new System.Drawing.Point(12, 92);
            this.cbSqColor.Name = "cbSqColor";
            this.cbSqColor.Size = new System.Drawing.Size(150, 21);
            this.cbSqColor.TabIndex = 4;
            this.cbSqColor.SelectedIndexChanged += new System.EventHandler(this.CbSqColor_SelectedIndexChanged);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(12, 150);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(93, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "C&ancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnDefaults
            // 
            this.btnDefaults.Location = new System.Drawing.Point(174, 150);
            this.btnDefaults.Name = "btnDefaults";
            this.btnDefaults.Size = new System.Drawing.Size(75, 23);
            this.btnDefaults.TabIndex = 7;
            this.btnDefaults.Text = "&Defaults";
            this.btnDefaults.UseVisualStyleBackColor = true;
            this.btnDefaults.Click += new System.EventHandler(this.BtnDefaults_Click);
            // 
            // psSqr
            // 
            this.psSqr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.psSqr.Image = null;
            this.psSqr.Location = new System.Drawing.Point(168, 76);
            this.psSqr.Name = "psSqr";
            this.psSqr.PyramidLocationIndex = 0;
            this.psSqr.Size = new System.Drawing.Size(60, 60);
            this.psSqr.TabIndex = 8;
            // 
            // OptionsDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 185);
            this.Controls.Add(this.psSqr);
            this.Controls.Add(this.btnDefaults);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbSqColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbChecker);
            this.Controls.Add(this.cbCheckerColor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "OptionsDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsDlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbChecker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCheckerColor;
        private System.Windows.Forms.PictureBox pbChecker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSqColor;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDefaults;
        private PyramidSquare psSqr;
    }
}