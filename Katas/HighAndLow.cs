using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    /// <summary>
    /// In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.
    /// Example:
    ///HighestAndLowest("1 2 3 4 5"); // return "5 1"
    ///HighestAndLowest("1 2 -3 4 5"); // return "5 -3"
    ///HighestAndLowest("1 9 3 4 -5"); // return "9 -5"
    /// 
    /// All numbers are valid Int32, no need to validate them.
    ///There will always be at least one number in the input string.
    ///Output string must be two numbers separated by a single space, and highest number is first.
    /// </summary>
    public static class HighAndLow
    {
        public static string HighestAndLowest(string numbers)
        {
            //split string by ' '
            var nums = numbers.Split(' ')
                .Select(int.Parse)
                .OrderBy(c => c).ToList();

            var high = nums.Max();
            var low = nums.Min();


            return $"{high} {low}";
        }
    }
}
