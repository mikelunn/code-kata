using System;
using Katas;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata.Tests
{
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
