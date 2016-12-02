using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    /// <summary>
    /// Given the triangle of consecutive odd numbers:
    ///             1
    ///          3     5
    ///       7     9    11
    ///   13    15    17    19
    ///21    23    25    27    29
    /// 
    /// Calculate the row sums of this triangle from the row 
    /// index (starting at index 1) e.g.:
    /// rowSumOddNumbers(1); // 1
    /// rowSumOddNumbers(2); // 3 + 5 = 8
    /// </summary>
    public static class SumOfOddNumbers
    {
        public static long RowSumOddNumbers(long n) => n*n*n;

    }
}
