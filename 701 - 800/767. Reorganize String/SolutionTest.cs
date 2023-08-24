using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ReorganizeString
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"a", "a"},
            new object[] {"aa", ""},
            new object[] {"aaa", ""},
            new object[] {"aab", "aba"},
            new object[] {"aaab", ""},
            new object[] {"aaabb", "ababa"},
            new object[] {"aaabbb", "ababab"},
            new object[] {"vvvlo", "vlvov"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string s, string expected)
        {
            var sol = new Solution();
            var res = sol.ReorganizeString(s);

            Assert.AreEqual(expected, res);
        }
    }
}