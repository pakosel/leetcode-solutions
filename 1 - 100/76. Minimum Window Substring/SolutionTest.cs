using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace MinimumWindowSubstring
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "ADOBECODEBANC", "ABC", "BANC" },
            new object[] { "ABAACBAB", "ABC", "ACB" },
            new object[] { "", "ABC", "" },
            new object[] { "ABCD", "EF", "" },
            new object[] { "A", "AA", "" },
            new object[] { "cabwefgewcwaefgcf", "cae", "cwae" },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string s, string t, string expected)
        {
            var sol = new Solution();
            var res = sol.MinWindow(s, t);

            Assert.AreEqual(res, expected);
        }
    }
}