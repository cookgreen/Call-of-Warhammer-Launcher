
namespace TotalWarModLauncher.Forms
{
    partial class frmLuaConsole
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
			this.txtLuaCode = new System.Windows.Forms.RichTextBox();
			this.txtLuaResult = new System.Windows.Forms.RichTextBox();
			this.main_tool_bar = new System.Windows.Forms.ToolStrip();
			this.btnStartTest = new System.Windows.Forms.ToolStripButton();
			this.main_tool_bar.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtLuaCode
			// 
			this.txtLuaCode.Location = new System.Drawing.Point(13, 30);
			this.txtLuaCode.Name = "txtLuaCode";
			this.txtLuaCode.Size = new System.Drawing.Size(600, 324);
			this.txtLuaCode.TabIndex = 0;
			this.txtLuaCode.Text = "";
			// 
			// txtLuaResult
			// 
			this.txtLuaResult.Location = new System.Drawing.Point(13, 360);
			this.txtLuaResult.Name = "txtLuaResult";
			this.txtLuaResult.ReadOnly = true;
			this.txtLuaResult.Size = new System.Drawing.Size(600, 143);
			this.txtLuaResult.TabIndex = 1;
			this.txtLuaResult.Text = "";
			// 
			// main_tool_bar
			// 
			this.main_tool_bar.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.main_tool_bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStartTest});
			this.main_tool_bar.Location = new System.Drawing.Point(0, 0);
			this.main_tool_bar.Name = "main_tool_bar";
			this.main_tool_bar.Size = new System.Drawing.Size(625, 27);
			this.main_tool_bar.TabIndex = 2;
			this.main_tool_bar.Text = "toolStrip1";
			// 
			// btnStartTest
			// 
			this.btnStartTest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnStartTest.Image = global::TotalWarModLauncher.Properties.Resources.start;
			this.btnStartTest.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnStartTest.Name = "btnStartTest";
			this.btnStartTest.Size = new System.Drawing.Size(29, 24);
			this.btnStartTest.Text = "Start";
			this.btnStartTest.Click += new System.EventHandler(this.btnStartTest_Click);
			// 
			// frmLuaConsole
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(625, 515);
			this.Controls.Add(this.main_tool_bar);
			this.Controls.Add(this.txtLuaResult);
			this.Controls.Add(this.txtLuaCode);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmLuaConsole";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lua Console";
			this.main_tool_bar.ResumeLayout(false);
			this.main_tool_bar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtLuaCode;
        private System.Windows.Forms.RichTextBox txtLuaResult;
        private System.Windows.Forms.ToolStrip main_tool_bar;
        private System.Windows.Forms.ToolStripButton btnStartTest;
    }
}