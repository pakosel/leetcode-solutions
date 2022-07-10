using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace RepeatedStringMatch
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "a", "a", 1 },
            new object[] { "a", "aa", 2 },
            new object[] { "a", "x", -1 },
            new object[] { "abcd", "cdabcdab", 3 },
            new object[] { "abc", "wxyz", -1 },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string a, string b, int expected)
        {
            var sol = new Solution();
            var res = sol.RepeatedStringMatch(a, b);

            Assert.AreEqual(expected, res);
        }
    }
}