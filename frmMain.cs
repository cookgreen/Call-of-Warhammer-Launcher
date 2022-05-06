using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoWLauncher
{
    public partial class frmMain : Form
    {
        private CoWSetting setting;

        public frmMain()
        {
            InitializeComponent();
            setting = new CoWSetting("./cow.ini");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string m2kingdom = setting.M2KingdomPath;
            string cowPath = Path.Combine(m2kingdom, "mods/Call_of_Warhammer");

            if (!Directory.Exists(cowPath))
            {
                MessageBox.Show("You don't install the Call of Warhammer mod!");
                return;
            }

            string cowCfgPath = Path.Combine(cowPath, "warhammer.cfg");

            if (chkRemoveTextBin.Checked)
            {
                List<string> filesNeedToRemove = new List<string>();
                string cowTextPath = Path.Combine(cowPath, "data\\text");
                DirectoryInfo di = new DirectoryInfo(cowTextPath);
                foreach (var file in di.EnumerateFiles())
                {
                    if(file.Extension == ".bin")
                    {
                        filesNeedToRemove.Add(file.FullName);
                    }
                }
                foreach (var fileName in filesNeedToRemove)
                {
                    File.Delete(fileName);
                }
            }

            if (chkRemoveRWNFile.Checked)
            {
                string cowMapPath = Path.Combine(cowPath, "data\\world\\maps\\campaign\\imperial_campaign");
                List<string> filesNeedToRemove = new List<string>();
                DirectoryInfo di = new DirectoryInfo(cowMapPath);
                foreach (var file in di.EnumerateFiles())
                {
                    if (file.Extension == ".rwn")
                    {
                        filesNeedToRemove.Add(file.FullName);
                    }
                }
                foreach (var fileName in filesNeedToRemove)
                {
                    File.Delete(fileName);
                }
            }

            Process kingdomProcess = new Process();
            kingdomProcess.StartInfo.FileName = "cmd.exe";
            kingdomProcess.StartInfo.UseShellExecute = false;
            kingdomProcess.StartInfo.RedirectStandardInput = true;
            kingdomProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            kingdomProcess.Start();
            List<string> commandInputs = new List<string>()
            {
                "cd \"" + m2kingdom +"\"",
                "kingdoms.exe @mods\\Call_of_Warhammer\\warhammer.cfg"
            };
            foreach (var command in commandInputs)
            {
                kingdomProcess.StandardInput.WriteLine(command);
            }

            Hide();

            kingdomProcess.WaitForExit();

            Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuFileSetting_Click(object sender, EventArgs e)
        {
            frmSetting settingWin = new frmSetting(setting);
            if(settingWin.ShowDialog() == DialogResult.OK)
            {
                setting = settingWin.NewSetting;
            }
        }
    }
}
