using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace GenerateParentheses
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { 0, new string[] {""} },
            new object[] { 1, new string[] {"()"} },
            new object[] { 2, new string[] {"(())","()()"} },
            new object[] { 3, new string[] {"((()))","(()())","(())()","()(())","()()()"} },
            new object[] { 4, new string[] {"(((())))","((()()))","((())())","((()))()","(()(()))","(()()())","(()())()","(())(())","(())()()","()((()))","()(()())","()(())()","()()(())","()()()()"} },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int n, string[] expected)
        {
            var sol = new Solution();
            var res = sol.GenerateParenthesis(n);

            CollectionAssert.AreEquivalent(res, expected);
        }
    }
}