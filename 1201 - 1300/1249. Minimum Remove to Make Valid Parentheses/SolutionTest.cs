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
            new object[] { "a", new string[] {"a"} },
            new object[] { "(", new string[] {""} },
            new object[] { ")", new string[] {""} },
            new object[] { "lee(t(c)o)de)", new string[] {"lee(t(c)o)de"} },
            new object[] { "a)b(c)d", new string[] {"ab(c)d"} },
            new object[] { "))((", new string[] {""} },
            new object[] { "(a(b(c)d)", new string[] {"a(b(c)d)", "(a(bc)d)"} },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic2024(string s, string[] expected)
        {
            var sol = new Solution2024();
            var res = sol.MinRemoveToMakeValid(s);

            Assert.That(res, Is.AnyOf(expected));
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string s, string[] expected)
        {
            var sol = new Solution();
            var res = sol.MinRemoveToMakeValid(s);

            Assert.That(res, Is.AnyOf(expected));
        }
    }
}