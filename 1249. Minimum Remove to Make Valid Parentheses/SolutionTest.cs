using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace MinimumRemoveToMakeValidParentheses
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "a", "a" },
            new object[] { "(", "" },
            new object[] { ")", "" },
            new object[] { "lee(t(c)o)de)", "lee(t(c)o)de" },
            new object[] { "a)b(c)d", "ab(c)d" },
            new object[] { "))((", "" },
            new object[] { "(a(b(c)d)", "a(b(c)d)" },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string s, string expected)
        {
            var sol = new Solution();
            var res = sol.MinRemoveToMakeValid(s);

            Assert.AreEqual(res, expected);
        }
    }
}