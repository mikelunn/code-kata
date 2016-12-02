using System;
using Katas;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata.Tests
{
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
