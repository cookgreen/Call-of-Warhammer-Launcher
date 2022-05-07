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
            setting.ChangeM2KingdomPath(txtM2KingdomPath.Text);
            setting.Save("./cow.ini");
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
