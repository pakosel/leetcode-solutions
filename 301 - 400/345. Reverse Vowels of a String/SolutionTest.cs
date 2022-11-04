using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ReverseVowelsOfString
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"hello", "holle"},
            new object[] {"leetcode", "leotcede"},
            new object[] {"hellOworldAbbXi", "hillAworldObbXe"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Stack(string s, string expected)
        {
            var sol = new Solution();
            var res = sol.ReverseVowels(s);

            Assert.AreEqual(expected, res);
        }
    }
}