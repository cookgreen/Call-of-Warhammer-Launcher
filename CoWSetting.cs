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
        public string M2KingdomPath
        {
            get { return m2KingdomPath; }
        }

        public CoWSetting(string settingFile)
        {
            parseSettingFile(settingFile);
        }

        private void parseSettingFile(string settingFile)
        {
            StreamReader reader = new StreamReader(settingFile);
            string line = reader.ReadLine();
            string[] tokens = line.Split('=');
            if (tokens[0].Trim() == "M2KingdomPath")
            {
                m2KingdomPath = tokens[1].Trim();
            }
            reader.Close();
        }

        public void ChangeM2KingdomPath(string newPath)
        {
            m2KingdomPath = newPath;
        }

        public void Save(string file)
        {
            StreamWriter writer = new StreamWriter(file);

            writer.WriteLine(string.Format("M2KingdomPath = {0}", m2KingdomPath));
            
            writer.Close();
        }
    }
}
