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
            new object[] { "a", "a", "a" },
            new object[] { "a", "aa", "" },
            new object[] { "A", "AA", "" },
            new object[] { "", "ABC", "" },
            new object[] { "ADOBECODEBANC", "ABC", "BANC" },
            new object[] { "ABAACBAB", "ABC", "ACB" },
            new object[] { "ABCD", "EF", "" },
            new object[] { "cabwefgewcwaefgcf", "cae", "cwae" },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic_2022(string s, string t, string expected)
        {
            var sol = new Solution_2022();
            var res = sol.MinWindow(s, t);

            Assert.That(expected == res);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string s, string t, string expected)
        {
            var sol = new Solution();
            var res = sol.MinWindow(s, t);

            Assert.That(expected == res);
        }
    }
}