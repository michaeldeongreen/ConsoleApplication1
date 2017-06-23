using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Extensions
{
    public static class StringExtensions
    {
        public static bool ContainsSubstring(this IEnumerable<string> substrings, string value)
        {
            foreach (string s in substrings)
            {
                if (value.IndexOf(s, StringComparison.OrdinalIgnoreCase) >= 0)
                    return true;
            }
            return false;
        }
    }
}
