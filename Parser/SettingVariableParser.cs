using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoWLauncher
{
    public class SettingVariableParser : IVariableParser
    {
        private CoWSetting setting;

        public SettingVariableParser(CoWSetting setting)
        {
            this.setting = setting;
        }

        public ParserType ParserType { get { return ParserType.Class; } }

        public string ParseString()
        {
            return null;
        }

        public object ParseMemberValue(string memberName)
        {
            return setting.GetType().GetProperty(memberName).GetValue(setting);
        }
    }
}
