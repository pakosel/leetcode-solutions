using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace DistinctSubsequences
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "", "", 1 },
            new object[] { "abc", "", 1 },
            new object[] { "", "bag", 0 },
            new object[] { "aaa", "aa", 3 },
            new object[] { "rabbbit", "rabbit", 3 },
            new object[] { "babgbag", "bag", 5 },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string s, string t, int expected)
        {
            var sol = new Solution();
            var res = sol.NumDistinct(s, t);

            Assert.AreEqual(res, expected);
        }
        
        [Test]
        [TestCaseSource("testCases")]
        public void Test_Memoization(string s, string t, int expected)
        {
            var sol = new Solution_Memo();
            var res = sol.NumDistinct(s, t);

            Assert.AreEqual(res, expected);
        }
    }
}