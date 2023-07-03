using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace BuddyStrings
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"ab", "ba", true},
            new object[] {"ab", "ab", false},
            new object[] {"aa", "aa", true},
            new object[] {"abac", "abad", false},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string s, string goal, bool expected)
        {
            var sol = new Solution();
            var res = sol.BuddyStrings(s, goal);

            Assert.AreEqual(expected, res);
        }
    }
}