using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace StackStabilization
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {1, "[2]", 1, 1, 0},
            new object[] {2, "[2,3]", 1, 1, 0},
            new object[] {2, "[3,2]", 1, 1, 2},
            new object[] {2, "[3,2]", 4, 1, 2},
            new object[] {2, "[3,2]", 1, 4, 2},
            new object[] {5, "[2, 5, 3, 6, 5]", 1, 1, 5},
            new object[] {3, "[100, 100, 100]", 2, 3, 5},
            new object[] {3, "[100, 100, 100]", 7, 3, 9},
            new object[] {4, "[6, 5, 4, 3]", 10, 1, 19},
            new object[] {4, "[100, 100, 1, 1]", 2, 1, 207},
            new object[] {6, "[6, 5, 2, 4, 4, 7]", 1, 1, 10},
            new object[] {8, "[8, 1, 11, 5, 17, 13, 19, 18]", 1, 1, 22},    //1,2,4,5,12,13,17,18
            new object[] {10, "[12, 24, 18, 1, 8, 23, 21, 13, 25, 19]", 1, 1, 56},
            new object[] {10, "[12, 24, 18, 1, 8, 23, 21, 13, 25, 19]", 5, 3, 227},
            new object[] {10, "[1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000]", 1, 1, 25},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(int N, string rStr, int A, int B, int expected)
        {
            var R = ArrayHelper.ArrayFromString(rStr);

            var sol = new Solution();
            var res = sol.getMinimumSecondsRequired(N, R, A, B);

            Assert.AreEqual(expected, res);
        }
    }
}