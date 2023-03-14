using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalWarModLauncher
{
    public class SettingVariableParser : IVariableParser
    {
        private TotalWarSetting setting;

        public SettingVariableParser(TotalWarSetting setting)
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
