using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalWarModLauncher
{
    public class KingdomExeVariableParser : IVariableParser
    {
        public ParserType ParserType { get { return ParserType.String; } }

        public string ParseString()
        {
            return "kingdoms.exe";
        }

        public object ParseMemberValue(string memberName)
        {
            return null;
        }
    }
}
