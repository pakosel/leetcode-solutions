using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ValidPalindromeII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"aba", true},
            new object[] {"abca", true},
            new object[] {"abc", false},
            new object[] {"a", true},
            new object[] {"ab", true},
            new object[] {"abc", false},
            new object[] {"abcdeedcxba", true},
            new object[] {"ebcbbececabbacecbbcbe", true},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string s, bool expected)
        {
            var sol = new Solution();
            var res = sol.ValidPalindrome(s);

            Assert.That(expected == res);
        }
    }
}