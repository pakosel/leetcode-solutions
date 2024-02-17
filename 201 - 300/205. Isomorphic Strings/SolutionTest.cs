using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace IsomorphicStrings
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"egg", "add", true},
            new object[] {"foo", "bar", false},
            new object[] {"paper", "title", true},
            new object[] {"badc", "baba", false},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string s, string t, bool expected)
        {
            var sol = new Solution();
            var res = sol.IsIsomorphic(s, t);

            Assert.That(expected == res);
        }
    }
}