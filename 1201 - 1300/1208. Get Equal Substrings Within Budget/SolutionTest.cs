using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace GetEqualSubstringsWithinBudget
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"abcd", "bcdf", 3, 3},
            new object[] {"abcd", "cdef", 3, 1},
            new object[] {"abcd", "acde", 0, 1},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string s, string t, int maxCost, int expected)
        {
            var sol = new Solution();
            var res = sol.EqualSubstring(s, t, maxCost);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}