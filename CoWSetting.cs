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
        private string modName;
        private string launcherIcon;
        private string launcherBackground;

        public string M2KingdomPath
        {
            get { return m2KingdomPath; }
        }

        public string ModName
        {
            get { return modName; }
        }

        public string LauncherIcon
        {
            get { return launcherIcon; }
        }

        public string LauncherBackground
        {
            get { return launcherBackground; }
        }

        public CoWSetting(string settingFile)
        {
            parseSettingFile(settingFile);
        }

        private void parseSettingFile(string settingFile)
        {
            StreamReader reader = new StreamReader(settingFile);
            while (reader.Peek() > -1)
            {
                string line = reader.ReadLine();
                string[] tokens = line.Split('=');
                string tokenKey = tokens[0].Trim();
                string tokenValue = tokens[1].Trim();
                if (tokenKey == "M2KingdomPath")
                {
                    m2KingdomPath = tokenValue;
                }
                else if (tokenKey == "Mod")
                {
                    modName = tokenValue;
                }
                else if (tokenKey == "LauncherIcon")
                {
                    launcherIcon = tokenValue;
                }
                else if (tokenKey == "LauncherBackground")
                {
                    launcherBackground = tokenValue;
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
            this.modName = modName;
        }

        public void Save(string file)
        {
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine(string.Format("M2KingdomPath = {0}", m2KingdomPath));
            writer.WriteLine(string.Format("Mod = {0}", modName));
            writer.WriteLine(string.Format("LauncherIcon = {0}", launcherIcon));
            writer.WriteLine(string.Format("LauncherBackground = {0}", launcherBackground));
            writer.Close();
        }
    }
}
