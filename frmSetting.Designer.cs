
namespace CoWLauncher
{
    partial class frmSetting
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
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtModName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowseM2Kingdom = new System.Windows.Forms.Button();
            this.txtM2KingdomPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.button1);
            this.gbSettings.Controls.Add(this.txtModName);
            this.gbSettings.Controls.Add(this.label2);
            this.gbSettings.Controls.Add(this.btnBrowseM2Kingdom);
            this.gbSettings.Controls.Add(this.txtM2KingdomPath);
            this.gbSettings.Controls.Add(this.label1);
            this.gbSettings.Location = new System.Drawing.Point(13, 3);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(429, 243);
            this.gbSettings.TabIndex = 0;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtModName
            // 
            this.txtModName.Location = new System.Drawing.Point(128, 63);
            this.txtModName.Name = "txtModName";
            this.txtModName.Size = new System.Drawing.Size(227, 27);
            this.txtModName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mod Name:";
            // 
            // btnBrowseM2Kingdom
            // 
            this.btnBrowseM2Kingdom.Location = new System.Drawing.Point(364, 26);
            this.btnBrowseM2Kingdom.Name = "btnBrowseM2Kingdom";
            this.btnBrowseM2Kingdom.Size = new System.Drawing.Size(59, 29);
            this.btnBrowseM2Kingdom.TabIndex = 2;
            this.btnBrowseM2Kingdom.Text = "...";
            this.btnBrowseM2Kingdom.UseVisualStyleBackColor = true;
            this.btnBrowseM2Kingdom.Click += new System.EventHandler(this.btnBrowseM2Kingdom_Click);
            // 
            // txtM2KingdomPath
            // 
            this.txtM2KingdomPath.Location = new System.Drawing.Point(128, 28);
            this.txtM2KingdomPath.Name = "txtM2KingdomPath";
            this.txtM2KingdomPath.ReadOnly = true;
            this.txtM2KingdomPath.Size = new System.Drawing.Size(227, 27);
            this.txtM2KingdomPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kingdom Path:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(146, 263);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 29);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(246, 263);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 304);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gbSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetting";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtM2KingdomPath;
        private System.Windows.Forms.Button btnBrowseM2Kingdom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModName;
        private System.Windows.Forms.Button button1;
    }
}