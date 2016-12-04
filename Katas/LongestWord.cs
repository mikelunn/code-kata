using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Katas
{
    public static class LongestWord
    {
        public static string Execute(string sen)
        {
            return Regex.Replace(sen, "[^0-9a-zA-Z]+", " ")
                .Split(' ')
                .OrderByDescending(c => c.Length)
                .FirstOrDefault();
        }
    }
}
