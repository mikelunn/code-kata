using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    /// <summary>
    /// Using the C# language, have the function FirstReverse(str) take the str parameter being passed and return the string in reversed order. For example: if the input string is "Hello World and Coders" then your program should return the string sredoC dna dlroW olleH. 
    /// </summary>
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
