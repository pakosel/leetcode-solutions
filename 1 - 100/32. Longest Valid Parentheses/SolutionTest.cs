using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace LongestValidParentheses
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "", 0 },
            new object[] { "(", 0 },
            new object[] { ")", 0 },
            new object[] { "()", 2 },
            new object[] { "(()", 2 },
            new object[] { ")()())", 4 },
            new object[] { "()((())()", 6 },
            new object[] { "()(()", 2 },
            new object[] { "(()(", 2 },
            new object[] { ")()())", 4 },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string s, int expected)
        {
            var sol = new Solution();
            var res = sol.LongestValidParentheses(s);

            Assert.That(expected == res);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Stack(string s, int expected)
        {
            var sol = new Solution_Stack();
            var res = sol.LongestValidParentheses(s);

            Assert.That(expected == res);
        }
    }
}