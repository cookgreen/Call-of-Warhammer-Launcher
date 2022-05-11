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
            DirectoryInfo di = new DirectoryInfo(setting.LauncherIcon);
            if (File.Exists(di.FullName))
            {
                Icon = new Icon(di.FullName);
            }

            di = new DirectoryInfo(setting.LauncherBackground);
            if (File.Exists(di.FullName))
            {
                pbLauncherBackground.Image = new Bitmap(di.FullName);
            }

            Text = string.Format("{0} Mod Launcher - [{1}]", setting.ModName.Replace("_", " "), setting.Version);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            bool isContinue = true;

            //Directory Check
            while (!Directory.Exists(setting.M2KingdomPath) || 
                   !File.Exists(Path.Combine(setting.M2KingdomPath, "kingdoms.exe")))
            {
                frmSetting settingWin = new frmSetting(setting);
                if(settingWin.ShowDialog() == DialogResult.OK)
                {
                    setting = settingWin.NewSetting;
                }
                else
                {
                    isContinue = false;
                    break;
                }
            }

            if (!isContinue)
            {
                return;
            }

            string m2kingdom = setting.M2KingdomPath;
            string cowPath = Path.Combine(m2kingdom, "mods/" + setting.ModName);

            if (!Directory.Exists(cowPath))
            {
                MessageBox.Show("You don't install the Call of Warhammer mod!");
                return;
            }

            File.Copy("./cfg/warhammer_windowed.cfg", Path.Combine(cowPath, "warhammer_windowed.cfg"), true);

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

            string warhammerCfg = "warhammer.cfg";
            if (chkWindowed.Checked)
            {
                warhammerCfg = "warhammer_windowed.cfg";
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
                "kingdoms.exe @mods\\Call_of_Warhammer\\" + warhammerCfg
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
                setting.Save("./cow.ini");
            }
        }
    }
}
