using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    public static class FirstReverse
    {
        public static string Execute(string str)
        {
            var arr = str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);

        }
    }
}
