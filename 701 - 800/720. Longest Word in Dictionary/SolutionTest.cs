using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace LongestWordInDictionary
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { new string[] {"w", "wo", "wor", "worl", "world"}, "world" },
            new object[] { new string[] {"a", "banana", "app", "appl", "ap", "apply", "apple"}, "apple" },
            new object[] { new string[] {"apple", "banana"}, "" },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string[] words, string expected)
        {
            var sol = new Solution();
            var res = sol.LongestWord(words);

            Assert.That(expected == res);
        }
    }
}