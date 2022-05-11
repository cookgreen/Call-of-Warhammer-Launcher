using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoWLauncher
{
    public partial class frmSetting : Form
    {
        private CoWSetting setting;
        public CoWSetting NewSetting
        {
            get { return setting; }
        }

        public frmSetting(CoWSetting setting)
        {
            InitializeComponent();
            this.setting = setting;
            txtM2KingdomPath.Text = setting.M2KingdomPath;
            txtModName.Text = setting.ModName;
        }

        private void btnBrowseM2Kingdom_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "M2 Kingdom Main Executable|kingdoms.exe";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtM2KingdomPath.Text = Path.GetDirectoryName(dialog.FileName).Replace("\\", "/");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(!Directory.Exists(txtM2KingdomPath.Text))
            {
                MessageBox.Show("The Medieval II Total War kingdom.exe you input is invalid!");
                return;
            }

            if (!Directory.Exists(Path.Combine(txtM2KingdomPath.Text, txtModName.Text)))
            {
                MessageBox.Show("The Mod you input is invalid!");
                return;
            }

            setting.ChangeM2KingdomPath(txtM2KingdomPath.Text);
            setting.ChangeModName(txtModName.Text);
            setting.Save("./cow.ini");
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
