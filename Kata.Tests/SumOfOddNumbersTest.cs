using System;
using Katas;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata.Tests
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
    [TestClass]
    public class SumOfOddNumbersTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, SumOfOddNumbers.RowSumOddNumbers(1));
            Assert.AreEqual(74088, SumOfOddNumbers.RowSumOddNumbers(42));
        }
    }
}
