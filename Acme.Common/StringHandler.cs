using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Acme.Common
{
    public class StringHandler
    {
        public string InsertSpaces(string source)
        {
            string result = string.Empty;

            if (!String.IsNullOrWhiteSpace(source))
            {
                foreach (char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        result += " ";
                    }
                    result += letter;
                }
            }

            result = Regex.Replace(result, "^[ \t\r\n]+", "");
            result = Regex.Replace(result, "[ \t\r\n]+$", "");

            return result;
        }
    }
}
