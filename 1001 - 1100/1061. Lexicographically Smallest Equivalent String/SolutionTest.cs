using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace LexicographicallySmallestEquivalentString
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"parker", "morris", "parser", "makkek"},
            new object[] {"hello", "world", "hold", "hdld"},
            new object[] {"leetcode", "programs", "sourcecode", "aauaaaaada"},
            new object[] {"aprtws", "prsuat", "oprstuwx", "oaaaaaax"},
            new object[] {"aprtwt", "prsuas", "oprstuwx", "oaaaaaax"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string s1, string s2, string baseStr, string expected)
        {
            var sol = new Solution();
            var res = sol.SmallestEquivalentString(s1, s2, baseStr);

            Assert.That(expected == res);
        }
    }
}