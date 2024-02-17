using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
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
            new object[] {"[[0,0,0,0,0,1,0,1,0,0,0,0,1,0,0,0,0,0],[0,0,0,0,0,0,1,0,0,0,0,1,0,1,0,1,0,0],[1,0,0,0,0,0,1,0,0,0,0,0,1,0,1,1,0,1],[0,0,0,1,0,0,1,0,0,0,0,0,0,0,0,0,0,0],[0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0],[0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,1,0],[0,0,0,0,0,1,0,0,0,0,1,1,0,1,0,0,0,0],[1,0,0,0,1,0,0,1,0,0,0,0,0,0,0,0,1,0],[0,0,0,0,1,0,0,0,1,0,0,0,1,0,0,0,0,0],[0,0,0,0,0,1,0,0,0,0,0,0,1,0,0,0,0,0],[0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0],[1,1,0,0,0,0,0,0,0,0,1,0,0,0,0,1,0,0],[0,0,1,0,1,0,0,0,0,0,0,1,0,0,0,0,0,0],[0,1,0,0,0,1,0,0,0,0,0,0,0,0,1,0,0,0],[0,0,1,0,0,0,0,1,0,0,0,0,0,1,0,0,0,1],[0,1,0,1,0,1,0,0,0,0,0,0,0,1,0,0,0,0],[0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,1],[1,0,1,1,0,0,0,0,0,0,1,0,1,0,0,0,1,0],[0,0,0,1,0,0,0,0,1,1,1,0,0,1,0,1,1,0],[0,1,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0],[0,1,1,0,0,1,0,0,0,0,0,0,0,1,1,0,0,0],[0,0,0,0,0,0,1,0,1,0,0,1,0,1,1,1,0,0],[0,0,0,1,0,0,0,0,0,0,0,0,0,0,1,0,1,1],[0,1,0,0,0,0,0,0,0,0,1,0,1,0,1,0,1,0],[1,0,0,1,0,1,0,0,1,0,0,0,0,0,0,0,0,0],[0,0,0,1,0,0,1,0,0,0,0,0,0,0,0,0,0,0],[0,1,0,0,0,0,0,1,0,0,0,0,0,0,1,1,1,0],[1,0,1,0,1,0,0,0,0,0,0,1,1,0,0,0,0,1],[1,0,0,0,0,0,1,1,0,0,0,1,0,0,0,0,0,0]]", 13594824},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Backtrack(string gridStr, int expected)
        {
            var grid = ArrayHelper.MatrixFromString<int>(gridStr);
            var sol = new Solution_Backtrack();
            var res = sol.UniquePathsWithObstacles(grid);

            Assert.That(expected == res);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_TopDown(string gridStr, int expected)
        {
            var grid = ArrayHelper.MatrixFromString<int>(gridStr);
            var sol = new Solution();
            var res = sol.UniquePathsWithObstacles(grid);

            Assert.That(expected == res);
        }
    }
}