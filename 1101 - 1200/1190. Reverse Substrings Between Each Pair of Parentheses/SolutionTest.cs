using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ReverseSubstringsBetweenEachPairOfParentheses
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"(abcd)", "dcba"},
            new object[] {"(u(love)i)", "iloveu"},
            new object[] {"(ed(et(oc))el)", "leetcode"},
            new object[] {"(u(love)i(abcd))", "abcdiloveu"},
            new object[] {"(u(love)i(abcd)x)", "xabcdiloveu"},
            new object[] {"abc", "abc"},
            new object[] {"abc(def)ghi(jkl)xyz", "abcfedghilkjxyz"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string s, string expected)
        {
            var sol = new Solution();
            var res = sol.ReverseParentheses(s);

            Assert.That(res, Is.EqualTo(expected));
        }
    }
}