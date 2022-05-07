
namespace CoWLauncher
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.chkRemoveRWNFile = new System.Windows.Forms.CheckBox();
            this.chkRemoveTextBin = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.chkWindowed = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CoWLauncher.Properties.Resources.CoW;
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(657, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(222, 351);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(211, 91);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // chkRemoveRWNFile
            // 
            this.chkRemoveRWNFile.AutoSize = true;
            this.chkRemoveRWNFile.BackColor = System.Drawing.Color.Transparent;
            this.chkRemoveRWNFile.Checked = true;
            this.chkRemoveRWNFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRemoveRWNFile.Location = new System.Drawing.Point(222, 259);
            this.chkRemoveRWNFile.Name = "chkRemoveRWNFile";
            this.chkRemoveRWNFile.Size = new System.Drawing.Size(158, 24);
            this.chkRemoveRWNFile.TabIndex = 2;
            this.chkRemoveRWNFile.Text = "Remove map.rwn";
            this.chkRemoveRWNFile.UseVisualStyleBackColor = false;
            // 
            // chkRemoveTextBin
            // 
            this.chkRemoveTextBin.AutoSize = true;
            this.chkRemoveTextBin.Checked = true;
            this.chkRemoveTextBin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRemoveTextBin.Location = new System.Drawing.Point(222, 307);
            this.chkRemoveTextBin.Name = "chkRemoveTextBin";
            this.chkRemoveTextBin.Size = new System.Drawing.Size(153, 24);
            this.chkRemoveTextBin.TabIndex = 3;
            this.chkRemoveTextBin.Text = "Remove Text Bin";
            this.chkRemoveTextBin.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(657, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileSetting,
            this.toolStripMenuItem1,
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuFileSetting
            // 
            this.mnuFileSetting.Name = "mnuFileSetting";
            this.mnuFileSetting.Size = new System.Drawing.Size(145, 26);
            this.mnuFileSetting.Text = "Setting";
            this.mnuFileSetting.Click += new System.EventHandler(this.mnuFileSetting_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(142, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(145, 26);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // chkWindowed
            // 
            this.chkWindowed.AutoSize = true;
            this.chkWindowed.Location = new System.Drawing.Point(222, 209);
            this.chkWindowed.Name = "chkWindowed";
            this.chkWindowed.Size = new System.Drawing.Size(110, 24);
            this.chkWindowed.TabIndex = 5;
            this.chkWindowed.Text = "Windowed";
            this.chkWindowed.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 454);
            this.Controls.Add(this.chkWindowed);
            this.Controls.Add(this.chkRemoveTextBin);
            this.Controls.Add(this.chkRemoveRWNFile);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Call of Warhammer Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox chkRemoveRWNFile;
        private System.Windows.Forms.CheckBox chkRemoveTextBin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSetting;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.CheckBox chkWindowed;
    }
}

