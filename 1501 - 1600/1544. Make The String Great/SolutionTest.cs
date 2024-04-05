using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MakeTheStringGreat
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"leEeetcode", "leetcode"},
            new object[] {"abBAcC", ""},
            new object[] {"s", "s"},
            new object[] {"leEEeetcode", "letcode"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic2024(string s, string expected)
        {
            var sol = new Solution2024();
            var res = sol.MakeGood(s);

            Assert.That(expected == res);
        }
 
        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string s, string expected)
        {
            var sol = new Solution();
            var res = sol.MakeGood(s);

            Assert.That(expected == res);
        }
    }
}