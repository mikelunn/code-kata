using System;
using Katas;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata.Tests
{
    /// <summary>
    /// Using the C# language, have the function
    ///  FirstFactorial(num) take the num parameter
    ///  being passed and return the factorial
    ///  of it (e.g. if num = 4, return (4 * 3 * 2 * 1)).
    ///  For the test cases, the range will be 
    /// between 1 and 18 and the input will always be an integer. 
    /// </summary>
    [TestClass]
    public class FirstFactorialTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(24, FirstFactorial.Execute(4));
            Assert.AreEqual(40320, FirstFactorial.Execute(8));
        }
    }
}
