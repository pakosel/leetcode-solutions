using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace PalindromicSubstrings
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "", 0 },
            new object[] { "a", 1 },
            new object[] { "aa", 3 },
            new object[] { "aaa", 6 },
            new object[] { "racecar", 10 },
            new object[] { "question", 8 },
            new object[] { "abba", 6 },
            new object[] { "amanaplanacanalpanama", 37 },
            new object[] { "abbababaabba", 24 },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string s, int expected)
        {
            var sol = new Solution();
            var res = sol.CountSubstrings(s);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}