using System;
using Katas;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata.Tests
{
    [TestClass]
    public class FirstReverseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("etybredoc", FirstReverse.Execute("coderbyte"));
            Assert.AreEqual("edoC evoL I", FirstReverse.Execute("I Love Code"));
        }
    }
}
