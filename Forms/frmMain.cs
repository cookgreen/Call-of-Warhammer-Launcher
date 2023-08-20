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
using TotalWarModLauncher.Forms;
using NLua;
using NLua.Exceptions;

namespace TotalWarModLauncher
{
    public partial class frmMain : Form
    {
        private Lua luaEnv;
        private ExpressionParser expressionParser;
        private TotalWarSetting setting;

        public frmMain()
        {
            InitializeComponent();

            setting = new TotalWarSetting("./setting.ini");

            luaEnv = new Lua();
            luaEnv.LoadCLRPackage();

            expressionParser = new ExpressionParser(setting);

            DirectoryInfo di = new DirectoryInfo(setting.LauncherIcon);
            if (File.Exists(di.FullName))
            {
                Icon = new Icon(di.FullName);
            }

            di = new DirectoryInfo(setting.LauncherBackground);
            if (File.Exists(di.FullName))
            {
                panelLauncherBackground.BackgroundImage = new Bitmap(di.FullName);
            }
            Text = string.Format("{0} Mod Launcher - [{1}]", setting.Mod.Replace("_", " "), setting.Version);


            int initLeft = 30;
            int initTop = 20;

            initTop += 15;

            for (int i = 0; i < setting.ScriptSettings.Count; i++)
            {
                initTop += 35;

                var scriptSetting = setting.ScriptSettings[i];
                if (scriptSetting.Type == "CheckBox")
                {
                    CheckBox checkBoxCtrl = new CheckBox();
                    checkBoxCtrl.AutoSize = true;
                    checkBoxCtrl.BackColor = Color.White;
                    checkBoxCtrl.Name = "chkCustom" + (i + 1);
                    checkBoxCtrl.Text = scriptSetting.Name;
                    checkBoxCtrl.Location = new Point(initLeft, initTop);
                    checkBoxCtrl.CheckedChanged += (o, e) => 
                    {
                        if ((o as CheckBox).Checked)
                        {
                            DirectoryInfo luaFileInfo = new DirectoryInfo(Path.Combine(setting.LuaScriptDir, scriptSetting.Script));
                            luaEnv.DoFile(luaFileInfo.FullName);
                            var func = luaEnv[scriptSetting.Function] as LuaFunction;

                            if (scriptSetting.Param1.StartsWith("{$SETTING}"))
                            {
                                string str = scriptSetting.Param1.Substring("{$SETTING}".Length + 1);
                                var paramValue = setting.GetType().GetProperty(str).GetValue(setting).ToString();

                                scriptSetting.Param1Value = paramValue;

                                if (string.IsNullOrEmpty(scriptSetting.Param2))
                                {
                                    scriptSetting.Func = func;
                                }
                            };

                            if (scriptSetting.Param2.StartsWith("{$SETTING}"))
                            {
                                string str = scriptSetting.Param2.Substring("{$SETTING}".Length + 1);
                                var paramValue = setting.GetType().GetProperty(str).GetValue(setting);
                                scriptSetting.Param2Value = paramValue.ToString();
                                scriptSetting.Func = func;
                            };
                        }
                        else
                        {
                            scriptSetting.Func = null;
                            scriptSetting.Param1Value = null;
                            scriptSetting.Param2Value = null;
                        }
                    };
                    checkBoxCtrl.Checked = true;
                    panelSetting.Controls.Add(checkBoxCtrl);
                }
            }
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
            string cowPath = Path.Combine(m2kingdom, "mods/" + setting.Mod);

            if (!Directory.Exists(cowPath))
            {
                MessageBox.Show("You don't install the required mod!");
                return;
            }

            string warhammerCfg = setting.ModConfig;

            for (int i = 0; i < setting.ScriptSettings.Count; i++)
            {
                var compliedScriptSetting = setting.ScriptSettings[i];
                if (compliedScriptSetting.Func != null)
                {
                    try
                    {
                        if (!string.IsNullOrEmpty(compliedScriptSetting.Param2Value))
                        {
                            compliedScriptSetting.Func.Call(compliedScriptSetting.Param1Value, compliedScriptSetting.Param2Value);
                        }
                        else
                        {
                            compliedScriptSetting.Func.Call(compliedScriptSetting.Param1Value);
                        }
                    }catch(LuaScriptException ex)
                    {
                        MessageBox.Show("Lua Exception: " + ex.ToString());
                    }
                }
            }

            string cmdLine = expressionParser.ParseCommandLine(setting.CommandLine);

            Process kingdomProcess = new Process();
            kingdomProcess.StartInfo.FileName = "cmd.exe";
            kingdomProcess.StartInfo.UseShellExecute = false;
            kingdomProcess.StartInfo.RedirectStandardInput = true;
            kingdomProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            kingdomProcess.Start();
            List<string> commandInputs = new List<string>()
            {
                "cd \"" + m2kingdom +"\"",
                cmdLine
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
                setting.Save("./setting.ini");
            }
        }

        private void mnuLuaConsole_Click(object sender, EventArgs e)
        {
            frmLuaConsole luaConsoleWin = new frmLuaConsole();
            luaConsoleWin.ShowDialog();
        }
    }
}
