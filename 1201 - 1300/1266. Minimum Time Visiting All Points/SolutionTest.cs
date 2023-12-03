using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MinimumTimeVisitingAllPoints
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[1,1],[3,4],[-1,0]]", 7},
            new object[] {"[[3,2],[-2,2]]", 5},
            new object[] {"[[1,1],[3,4],[-1,0],[2,0],[0,0],[0,0]]", 12},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string pointsStr, int expected)
        {
            var points = ArrayHelper.MatrixFromString<int>(pointsStr);

            var sol = new Solution();
            var res = sol.MinTimeToVisitAllPoints(points);

            Assert.AreEqual(expected, res);
        }
    }
}