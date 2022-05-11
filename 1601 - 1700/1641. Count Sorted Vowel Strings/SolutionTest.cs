using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CountSortedVowelStrings
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {1, 5},
            new object[] {2, 15},
            new object[] {3, 35},
            new object[] {4, 70},
            new object[] {5, 126},
            new object[] {33, 66045},
            new object[] {10, 1001},
            new object[] {44, 194580},
            new object[] {50, 316251},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(int n, int expected)
        {
            var sol = new Solution();
            var res = sol.CountVowelStrings(n);

            Assert.AreEqual(res, expected);
        }
    }
}