using System;
using Katas;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata.Tests
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
    [TestClass]
    public class HighAndLowTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("42 -9", 
                HighAndLow.HighestAndLowest("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
        }
    }
}
