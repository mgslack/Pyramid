
namespace Pyramid
{
    partial class MainWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWin));
            this.pnlPyramidBoard = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.pyramidSquare15 = new Pyramid.PyramidSquare();
            this.pyramidSquare14 = new Pyramid.PyramidSquare();
            this.pyramidSquare13 = new Pyramid.PyramidSquare();
            this.pyramidSquare12 = new Pyramid.PyramidSquare();
            this.pyramidSquare11 = new Pyramid.PyramidSquare();
            this.pyramidSquare10 = new Pyramid.PyramidSquare();
            this.pyramidSquare9 = new Pyramid.PyramidSquare();
            this.pyramidSquare8 = new Pyramid.PyramidSquare();
            this.pyramidSquare7 = new Pyramid.PyramidSquare();
            this.pyramidSquare6 = new Pyramid.PyramidSquare();
            this.pyramidSquare5 = new Pyramid.PyramidSquare();
            this.pyramidSquare4 = new Pyramid.PyramidSquare();
            this.pyramidSquare3 = new Pyramid.PyramidSquare();
            this.pyramidSquare2 = new Pyramid.PyramidSquare();
            this.pyramidSquare1 = new Pyramid.PyramidSquare();
            this.pnlPyramidBoard.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPyramidBoard
            // 
            this.pnlPyramidBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPyramidBoard.Controls.Add(this.pyramidSquare15);
            this.pnlPyramidBoard.Controls.Add(this.pyramidSquare14);
            this.pnlPyramidBoard.Controls.Add(this.pyramidSquare13);
            this.pnlPyramidBoard.Controls.Add(this.pyramidSquare12);
            this.pnlPyramidBoard.Controls.Add(this.pyramidSquare11);
            this.pnlPyramidBoard.Controls.Add(this.pyramidSquare10);
            this.pnlPyramidBoard.Controls.Add(this.pyramidSquare9);
            this.pnlPyramidBoard.Controls.Add(this.pyramidSquare8);
            this.pnlPyramidBoard.Controls.Add(this.pyramidSquare7);
            this.pnlPyramidBoard.Controls.Add(this.pyramidSquare6);
            this.pnlPyramidBoard.Controls.Add(this.pyramidSquare5);
            this.pnlPyramidBoard.Controls.Add(this.pyramidSquare4);
            this.pnlPyramidBoard.Controls.Add(this.pyramidSquare3);
            this.pnlPyramidBoard.Controls.Add(this.pyramidSquare2);
            this.pnlPyramidBoard.Controls.Add(this.pyramidSquare1);
            this.pnlPyramidBoard.Location = new System.Drawing.Point(12, 12);
            this.pnlPyramidBoard.Name = "pnlPyramidBoard";
            this.pnlPyramidBoard.Size = new System.Drawing.Size(341, 337);
            this.pnlPyramidBoard.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnUndo);
            this.panel1.Controls.Add(this.btnHelp);
            this.panel1.Controls.Add(this.btnOptions);
            this.panel1.Controls.Add(this.btnQuit);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Location = new System.Drawing.Point(368, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(84, 337);
            this.panel1.TabIndex = 1;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(4, 119);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 4;
            this.btnHelp.Text = "&Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(3, 90);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(75, 23);
            this.btnOptions.TabIndex = 3;
            this.btnOptions.Text = "&Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.BtnOptions_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(4, 61);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(3, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "&Start Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Enabled = false;
            this.btnUndo.Location = new System.Drawing.Point(3, 32);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 1;
            this.btnUndo.Text = "&Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.BtnUndo_Click);
            // 
            // pyramidSquare15
            // 
            this.pyramidSquare15.BackColor = System.Drawing.Color.Red;
            this.pyramidSquare15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pyramidSquare15.Image = null;
            this.pyramidSquare15.Location = new System.Drawing.Point(270, 267);
            this.pyramidSquare15.Name = "pyramidSquare15";
            this.pyramidSquare15.PyramidLocationIndex = 14;
            this.pyramidSquare15.Size = new System.Drawing.Size(60, 60);
            this.pyramidSquare15.TabIndex = 14;
            // 
            // pyramidSquare14
            // 
            this.pyramidSquare14.BackColor = System.Drawing.Color.Red;
            this.pyramidSquare14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pyramidSquare14.Image = null;
            this.pyramidSquare14.Location = new System.Drawing.Point(204, 267);
            this.pyramidSquare14.Name = "pyramidSquare14";
            this.pyramidSquare14.PyramidLocationIndex = 13;
            this.pyramidSquare14.Size = new System.Drawing.Size(60, 60);
            this.pyramidSquare14.TabIndex = 13;
            // 
            // pyramidSquare13
            // 
            this.pyramidSquare13.BackColor = System.Drawing.Color.Red;
            this.pyramidSquare13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pyramidSquare13.Image = null;
            this.pyramidSquare13.Location = new System.Drawing.Point(138, 267);
            this.pyramidSquare13.Name = "pyramidSquare13";
            this.pyramidSquare13.PyramidLocationIndex = 12;
            this.pyramidSquare13.Size = new System.Drawing.Size(60, 60);
            this.pyramidSquare13.TabIndex = 12;
            // 
            // pyramidSquare12
            // 
            this.pyramidSquare12.BackColor = System.Drawing.Color.Red;
            this.pyramidSquare12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pyramidSquare12.Image = null;
            this.pyramidSquare12.Location = new System.Drawing.Point(72, 267);
            this.pyramidSquare12.Name = "pyramidSquare12";
            this.pyramidSquare12.PyramidLocationIndex = 11;
            this.pyramidSquare12.Size = new System.Drawing.Size(60, 60);
            this.pyramidSquare12.TabIndex = 11;
            // 
            // pyramidSquare11
            // 
            this.pyramidSquare11.BackColor = System.Drawing.Color.Red;
            this.pyramidSquare11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pyramidSquare11.Image = null;
            this.pyramidSquare11.Location = new System.Drawing.Point(6, 267);
            this.pyramidSquare11.Name = "pyramidSquare11";
            this.pyramidSquare11.PyramidLocationIndex = 10;
            this.pyramidSquare11.Size = new System.Drawing.Size(60, 60);
            this.pyramidSquare11.TabIndex = 10;
            // 
            // pyramidSquare10
            // 
            this.pyramidSquare10.BackColor = System.Drawing.Color.Red;
            this.pyramidSquare10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pyramidSquare10.Image = null;
            this.pyramidSquare10.Location = new System.Drawing.Point(237, 201);
            this.pyramidSquare10.Name = "pyramidSquare10";
            this.pyramidSquare10.PyramidLocationIndex = 9;
            this.pyramidSquare10.Size = new System.Drawing.Size(60, 60);
            this.pyramidSquare10.TabIndex = 9;
            // 
            // pyramidSquare9
            // 
            this.pyramidSquare9.BackColor = System.Drawing.Color.Red;
            this.pyramidSquare9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pyramidSquare9.Image = null;
            this.pyramidSquare9.Location = new System.Drawing.Point(171, 201);
            this.pyramidSquare9.Name = "pyramidSquare9";
            this.pyramidSquare9.PyramidLocationIndex = 8;
            this.pyramidSquare9.Size = new System.Drawing.Size(60, 60);
            this.pyramidSquare9.TabIndex = 8;
            // 
            // pyramidSquare8
            // 
            this.pyramidSquare8.BackColor = System.Drawing.Color.Red;
            this.pyramidSquare8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pyramidSquare8.Image = null;
            this.pyramidSquare8.Location = new System.Drawing.Point(105, 201);
            this.pyramidSquare8.Name = "pyramidSquare8";
            this.pyramidSquare8.PyramidLocationIndex = 7;
            this.pyramidSquare8.Size = new System.Drawing.Size(60, 60);
            this.pyramidSquare8.TabIndex = 7;
            // 
            // pyramidSquare7
            // 
            this.pyramidSquare7.BackColor = System.Drawing.Color.Red;
            this.pyramidSquare7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pyramidSquare7.Image = null;
            this.pyramidSquare7.Location = new System.Drawing.Point(39, 201);
            this.pyramidSquare7.Name = "pyramidSquare7";
            this.pyramidSquare7.PyramidLocationIndex = 6;
            this.pyramidSquare7.Size = new System.Drawing.Size(60, 60);
            this.pyramidSquare7.TabIndex = 6;
            // 
            // pyramidSquare6
            // 
            this.pyramidSquare6.BackColor = System.Drawing.Color.Red;
            this.pyramidSquare6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pyramidSquare6.Image = null;
            this.pyramidSquare6.Location = new System.Drawing.Point(204, 135);
            this.pyramidSquare6.Name = "pyramidSquare6";
            this.pyramidSquare6.PyramidLocationIndex = 5;
            this.pyramidSquare6.Size = new System.Drawing.Size(60, 60);
            this.pyramidSquare6.TabIndex = 5;
            // 
            // pyramidSquare5
            // 
            this.pyramidSquare5.BackColor = System.Drawing.Color.Red;
            this.pyramidSquare5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pyramidSquare5.Image = null;
            this.pyramidSquare5.Location = new System.Drawing.Point(138, 135);
            this.pyramidSquare5.Name = "pyramidSquare5";
            this.pyramidSquare5.PyramidLocationIndex = 4;
            this.pyramidSquare5.Size = new System.Drawing.Size(60, 60);
            this.pyramidSquare5.TabIndex = 4;
            // 
            // pyramidSquare4
            // 
            this.pyramidSquare4.BackColor = System.Drawing.Color.Red;
            this.pyramidSquare4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pyramidSquare4.Image = null;
            this.pyramidSquare4.Location = new System.Drawing.Point(72, 135);
            this.pyramidSquare4.Name = "pyramidSquare4";
            this.pyramidSquare4.PyramidLocationIndex = 3;
            this.pyramidSquare4.Size = new System.Drawing.Size(60, 60);
            this.pyramidSquare4.TabIndex = 3;
            // 
            // pyramidSquare3
            // 
            this.pyramidSquare3.BackColor = System.Drawing.Color.Red;
            this.pyramidSquare3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pyramidSquare3.Image = null;
            this.pyramidSquare3.Location = new System.Drawing.Point(171, 69);
            this.pyramidSquare3.Name = "pyramidSquare3";
            this.pyramidSquare3.PyramidLocationIndex = 2;
            this.pyramidSquare3.Size = new System.Drawing.Size(60, 60);
            this.pyramidSquare3.TabIndex = 2;
            // 
            // pyramidSquare2
            // 
            this.pyramidSquare2.BackColor = System.Drawing.Color.Red;
            this.pyramidSquare2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pyramidSquare2.Image = null;
            this.pyramidSquare2.Location = new System.Drawing.Point(105, 69);
            this.pyramidSquare2.Name = "pyramidSquare2";
            this.pyramidSquare2.PyramidLocationIndex = 1;
            this.pyramidSquare2.Size = new System.Drawing.Size(60, 60);
            this.pyramidSquare2.TabIndex = 1;
            // 
            // pyramidSquare1
            // 
            this.pyramidSquare1.BackColor = System.Drawing.Color.Red;
            this.pyramidSquare1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pyramidSquare1.Image = null;
            this.pyramidSquare1.Location = new System.Drawing.Point(138, 3);
            this.pyramidSquare1.Name = "pyramidSquare1";
            this.pyramidSquare1.PyramidLocationIndex = 0;
            this.pyramidSquare1.Size = new System.Drawing.Size(60, 60);
            this.pyramidSquare1.TabIndex = 0;
            // 
            // MainWin
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 360);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlPyramidBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pyramid";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWin_FormClosed);
            this.Load += new System.EventHandler(this.MainWin_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainWin_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainWin_DragEnter);
            this.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.MainWin_GiveFeedback);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWin_MouseDown);
            this.pnlPyramidBoard.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPyramidBoard;
        private PyramidSquare pyramidSquare15;
        private PyramidSquare pyramidSquare14;
        private PyramidSquare pyramidSquare13;
        private PyramidSquare pyramidSquare12;
        private PyramidSquare pyramidSquare11;
        private PyramidSquare pyramidSquare10;
        private PyramidSquare pyramidSquare9;
        private PyramidSquare pyramidSquare8;
        private PyramidSquare pyramidSquare7;
        private PyramidSquare pyramidSquare6;
        private PyramidSquare pyramidSquare5;
        private PyramidSquare pyramidSquare4;
        private PyramidSquare pyramidSquare3;
        private PyramidSquare pyramidSquare2;
        private PyramidSquare pyramidSquare1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnUndo;
    }
}

