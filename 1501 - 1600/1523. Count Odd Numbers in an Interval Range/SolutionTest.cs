using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CountOddNumbersInAnIntervalRange
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {0,0, 0},
            new object[] {1,1, 1},
            new object[] {4,5, 1},
            new object[] {4,6, 1},
            new object[] {3,7, 3},
            new object[] {8,10, 1},
            new object[] {54, 684, 315},
            new object[] {54, 685, 316},
            new object[] {55, 684, 315},
            new object[] {55, 685, 316},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(int low, int high, int expected)
        {
            var sol = new Solution();
            var res = sol.CountOdds(low, high);

            Assert.AreEqual(expected, res);
        }
    }
}