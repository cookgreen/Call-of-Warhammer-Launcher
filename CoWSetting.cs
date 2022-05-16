using NLua;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoWLauncher
{
    public class CoWSetting
    {
        private string m2KingdomPath;
        private string mod;
        private string modConfig;
        private string launcherIcon;
        private string launcherBackground;
        private string version;
        private string luaScriptDir;
        private string luaScriptSettingsNum;
        private string commandLine;

        private List<CoWScriptSetting> scriptSettings;

        public string M2KingdomPath
        {
            get { return m2KingdomPath; }
        }

        public string Mod
        {
            get { return mod; }
        }

        public string ModConfig
        {
            get { return modConfig; }
        }

        public string LauncherIcon
        {
            get { return launcherIcon; }
        }

        public string LauncherBackground
        {
            get { return launcherBackground; }
        }

        public string Version
        {
            get { return version; }
        }

        public string LuaScriptDir
        {
            get { return luaScriptDir; }
        }

        public string LuaScriptSettingsNum
        {
            get { return luaScriptSettingsNum; }
        }

        public string CommandLine
        {
            get { return commandLine; }
        }

        public List<CoWScriptSetting> ScriptSettings
        {
            get { return scriptSettings; }
        }

        public CoWSetting(string settingFile)
        {
            scriptSettings = new List<CoWScriptSetting>();
            parseSettingFile(settingFile);
        }

        private void parseSettingFile(string settingFile)
        {
            StreamReader reader = new StreamReader(settingFile);

            CoWScriptSetting setting = null;

            while (reader.Peek() > -1)
            {
                string line = reader.ReadLine();
                
                if (line.StartsWith(";") || string.IsNullOrEmpty(line))//comment, skip;
                    continue;

                if (line.StartsWith("[") && line.EndsWith("]"))
                {
                    setting = new CoWScriptSetting();
                }
                else
                {
                    string[] tokens = line.Split('=');
                    string tokenKey = tokens[0].Trim();
                    string tokenValue = tokens[1].TrimStart().TrimEnd();
                    if (tokenKey == "M2KingdomPath")
                    {
                        m2KingdomPath = tokenValue;
                    }
                    else if (tokenKey == "Mod")
                    {
                        mod = tokenValue;
                    }
                    else if (tokenKey == "ModConfig")
                    {
                        modConfig = tokenValue;
                    }
                    else if (tokenKey == "LauncherIcon")
                    {
                        launcherIcon = tokenValue;
                    }
                    else if (tokenKey == "LauncherBackground")
                    {
                        launcherBackground = tokenValue;
                    }
                    else if (tokenKey == "Version")
                    {
                        version = tokenValue;
                    }
                    else if (tokenKey == "LuaScriptDir")
                    {
                        luaScriptDir = tokenValue;
                    }
                    else if (tokenKey == "LuaScriptSettingsNum")
                    {
                        luaScriptSettingsNum = tokenValue;
                    }
                    else if (tokenKey == "CommandLine")
                    {
                        commandLine = tokenValue;
                    }
                    else
                    {
                        if (setting != null)
                        {
                            if (tokenKey == "Name")
                            {
                                setting.Name = tokenValue;
                            }
                            else if (tokenKey == "Type")
                            {
                                setting.Type = tokenValue;
                            }
                            else if (tokenKey == "Script")
                            {
                                setting.Script = tokenValue;
                            }
                            else if (tokenKey == "Function")
                            {
                                setting.Function = tokenValue;
                            }
                            else if (tokenKey == "Param1")
                            {
                                setting.Param1 = tokenValue;
                            }
                            else if (tokenKey == "Param2")
                            {
                                setting.Param2 = tokenValue;
                                scriptSettings.Add(setting);

                                setting = null;
                            }
                        }
                    }
                }
            }
            reader.Close();
        }

        public void ChangeM2KingdomPath(string newPath)
        {
            m2KingdomPath = newPath;
        }

        public void ChangeModName(string modName)
        {
            this.mod = modName;
        }

        public void Save(string file)
        {
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine(string.Format("M2KingdomPath = {0}", m2KingdomPath));
            writer.WriteLine(string.Format("Mod = {0}", mod));
            writer.WriteLine(string.Format("ModConfig = {0}", modConfig));
            writer.WriteLine(string.Format("LauncherIcon = {0}", launcherIcon));
            writer.WriteLine(string.Format("LauncherBackground = {0}", launcherBackground));
            writer.WriteLine(string.Format("Version = {0}", version));
            writer.WriteLine(string.Format("LuaScriptDir = {0}", luaScriptDir));
            writer.WriteLine(string.Format("LuaScriptSettingsNum = {0}", luaScriptSettingsNum));
            writer.WriteLine(string.Format("CommandLine = {0}", commandLine));

            for (int i = 0; i < scriptSettings.Count; i++)
            {
                writer.WriteLine(string.Format("[LuaScriptSetting{0}]", i + 1));
                writer.WriteLine(string.Format("Name = {0}", scriptSettings[i].Name));
                writer.WriteLine(string.Format("Type = {0}", scriptSettings[i].Type));
                writer.WriteLine(string.Format("Script = {0}", scriptSettings[i].Script));
                writer.WriteLine(string.Format("Function = {0}", scriptSettings[i].Function));
                writer.WriteLine(string.Format("Param1 = {0}", scriptSettings[i].Param1));
                writer.WriteLine(string.Format("Param2 = {0}", scriptSettings[i].Param2));
            }

            writer.Close();
        }
    }

    public class CoWScriptSetting
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Script { get; set; }
        public string Function { get; set; }
        public string Param1 { get; set; }
        public string Param2 { get; set; }
        public string Param1Value { get; set; }
        public string Param2Value { get; set; }
        public LuaFunction Func { get; internal set; }
    }
}
