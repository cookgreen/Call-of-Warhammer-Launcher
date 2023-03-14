using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalWarModLauncher
{
    public enum ParserType
    {
        String,
        Class,
    }

    public interface IVariableParser
    {
        public ParserType ParserType { get; }
        public string ParseString();
        public object ParseMemberValue(string memberName);
    }
}
