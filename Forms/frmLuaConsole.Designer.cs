
namespace CoWLauncher.Forms
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnStartTest = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
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
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStartTest});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(625, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnStartTest
            // 
            this.btnStartTest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStartTest.Image = global::CoWLauncher.Properties.Resources.start;
            this.btnStartTest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(29, 24);
            this.btnStartTest.Text = "toolStripButton1";
            this.btnStartTest.Click += new System.EventHandler(this.btnStartTest_Click);
            // 
            // frmLuaConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 515);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtLuaResult);
            this.Controls.Add(this.txtLuaCode);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLuaConsole";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lua Console";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtLuaCode;
        private System.Windows.Forms.RichTextBox txtLuaResult;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnStartTest;
    }
}