using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    
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
