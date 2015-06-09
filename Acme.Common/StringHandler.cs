using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Acme.Common
{

    /// <summary>
    /// Breaks String up on capital letter adding a space.
    /// </summary>
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
                        // Trim any spaces already there
                        result = result.Trim();
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
