using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoWLauncher
{
    public class ExpressionParser
    {
        private const char VARIABLE_START__ID = '{';
        private const char VARIABLE_END_ID = '}';

        private Dictionary<string, IVariableParser> constVariableTable;

        public ExpressionParser(CoWSetting setting)
        {
            constVariableTable = new Dictionary<string, IVariableParser>()
            {
                { "$KINGDOM_EXE", new KingdomExeVariableParser()},
                { "$SETTING",  new SettingVariableParser(setting)}
            };
        }

        public string ParseCommandLine(string commandLine)
        {
            StringBuilder stringBuilder = null;
            List<Tuple<string, int>> tuples = new List<Tuple<string, int>>();
            int idx = 0;
            for (int i = 0; i < commandLine.Length; i++)
            {
                char ch = commandLine[i];
                if (ch == VARIABLE_START__ID)
                {
                    stringBuilder = new StringBuilder();
                    stringBuilder.Append(ch);
                }
                else if (ch == VARIABLE_END_ID)
                {
                    stringBuilder.Append(ch);

                    string str = stringBuilder.ToString();
                    string variable = str.Substring(1, str.Length - 2);

                    tuples.Add(new Tuple<string, int>(variable, idx));

                    stringBuilder = null;
                    idx++;
                }
                else if (stringBuilder != null)
                {
                    stringBuilder.Append(ch);
                }
            }

            for (int i = 0; i < tuples.Count; i++)
            {
                var varlue = tuples[i].Item1;
                string vairableValue;
                if (varlue.Contains("."))
                {
                    string[] tokens = varlue.Split('.');
                    string variable = tokens[0];
                    string variableMmeber = tokens[1];
                    var paser = constVariableTable[variable];
                    vairableValue = paser.ParseMemberValue(variableMmeber).ToString();
                }
                else
                {
                    var paser = constVariableTable[varlue];
                    vairableValue = paser.ParseString();
                }
                commandLine = commandLine.Replace("{" + tuples[i].Item1 + "}", vairableValue);
            }

            return commandLine;
        }
    }
}
