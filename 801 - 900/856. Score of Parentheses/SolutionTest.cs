using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ScoreOfParentheses
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"()", 1},
            new object[] {"(())", 2},
            new object[] {"()()", 2},
            new object[] {"((()))", 4},
            new object[] {"(((()()())))", 24},
            new object[] {"(((()()(()()))))", 48},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string s, int expected)
        {
            var sol = new Solution();
            var res = sol.ScoreOfParentheses(s);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}