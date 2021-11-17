using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace UniquePathsII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[[1],[1]]", 0},
            new object[] {"[[0],[0]]", 1},
            new object[] {"[[0,0]]", 1},
            new object[] {"[[0],[1]]", 0},
            new object[] {"[[0],[1],[0]]", 0},
            new object[] {"[[0,1,0]]", 0},
            new object[] {"[[0,0],[0,1]]", 0},
            new object[] {"[[0,0],[1,1],[0,0]]", 0},
            new object[] {"[[0,0,0],[0,1,0],[0,0,0]]", 2},
            new object[] {"[[0,1],[0,0]]", 1},
            new object[] {"[[0,0,0,0,1],[0,1,0,0,0],[1,0,0,0,0]]", 5},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string gridStr, int expected)
        {
            var grid = ArrayHelper.MatrixFromString(gridStr);
            var sol = new Solution();
            var res = sol.UniquePathsWithObstacles(grid);

            Assert.AreEqual(res, expected);
        }
    }
}