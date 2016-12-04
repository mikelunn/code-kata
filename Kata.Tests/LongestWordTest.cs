using System;
using Katas;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata.Tests
{
    /// <summary>
    /// Using the C# language, have the function LongestWord(sen) take the sen parameter being passed and return the largest word in the string. If there are two or more words that are the same length, return the first word from the string with that length. Ignore punctuation and assume sen will not be empty. 
    /// </summary>
    [TestClass]
    public class LongestWordTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("time", LongestWord.Execute("fun&!! time"));
            Assert.AreEqual("love", LongestWord.Execute("I love dogs"));
          
        }
    }
}
