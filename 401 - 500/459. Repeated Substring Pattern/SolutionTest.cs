using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace RepeatedSubstringPattern
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "", false },
            new object[] { "a", false },
            new object[] { "aa", true },
            new object[] { "aaa", true },
            new object[] { "abab", true },
            new object[] { "aba", false },
            new object[] { "abcabcabcabc", true },
            new object[] { "repeatedsubstringsatternrepeatedsubstringsatternrepeatedsubstringsatternrepeatedsubstringsattern", true },
            new object[] { "epeatedsubstringsatternrepeatedsubstringsattern", false },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string input, bool expected)
        {
            var sol = new Solution();
            var res = sol.RepeatedSubstringPattern(input);

            Assert.AreEqual(expected, res);
        }
    }
}