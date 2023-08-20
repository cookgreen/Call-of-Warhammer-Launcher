
namespace TotalWarModLauncher
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
			this.panelLauncherBackground = new System.Windows.Forms.Panel();
			this.panelSetting = new System.Windows.Forms.Panel();
			this.btnStart = new System.Windows.Forms.Button();
			this.menu = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileSetting = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuLuaConsole = new System.Windows.Forms.ToolStripMenuItem();
			this.panelLauncherBackground.SuspendLayout();
			this.menu.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelLauncherBackground
			// 
			this.panelLauncherBackground.BackgroundImage = global::TotalWarModLauncher.Properties.Resources.CoW;
			this.panelLauncherBackground.Controls.Add(this.panelSetting);
			this.panelLauncherBackground.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelLauncherBackground.Location = new System.Drawing.Point(0, 28);
			this.panelLauncherBackground.Name = "panelLauncherBackground";
			this.panelLauncherBackground.Size = new System.Drawing.Size(657, 426);
			this.panelLauncherBackground.TabIndex = 0;
			// 
			// panelSetting
			// 
			this.panelSetting.BackColor = System.Drawing.Color.Transparent;
			this.panelSetting.Location = new System.Drawing.Point(199, 134);
			this.panelSetting.Name = "panelSetting";
			this.panelSetting.Size = new System.Drawing.Size(250, 169);
			this.panelSetting.TabIndex = 0;
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
			// menu
			// 
			this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
			this.menu.Location = new System.Drawing.Point(0, 0);
			this.menu.Name = "menu";
			this.menu.Size = new System.Drawing.Size(657, 28);
			this.menu.TabIndex = 4;
			this.menu.Text = "menuStrip1";
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
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLuaConsole});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
			this.toolsToolStripMenuItem.Text = "Tools";
			// 
			// mnuLuaConsole
			// 
			this.mnuLuaConsole.Name = "mnuLuaConsole";
			this.mnuLuaConsole.Size = new System.Drawing.Size(180, 26);
			this.mnuLuaConsole.Text = "Lua Console";
			this.mnuLuaConsole.Click += new System.EventHandler(this.mnuLuaConsole_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(657, 454);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.panelLauncherBackground);
			this.Controls.Add(this.menu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menu;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Call of Warhammer Launcher";
			this.panelLauncherBackground.ResumeLayout(false);
			this.menu.ResumeLayout(false);
			this.menu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLauncherBackground;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSetting;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuLuaConsole;
        private System.Windows.Forms.Panel panelSetting;
    }
}

