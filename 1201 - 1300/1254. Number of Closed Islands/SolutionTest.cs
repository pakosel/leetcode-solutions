using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace NumberOfClosedIslands
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[1,1,1,1,1,1,1,0],[1,0,0,0,0,1,1,0],[1,0,1,0,1,1,1,0],[1,0,0,0,0,1,0,1],[1,1,1,1,1,1,1,0]]", 2},
            new object[] {"[[0,0,1,0,0],[0,1,0,1,0],[0,1,1,1,0]]", 1},
            new object[] {"[[1,1,1,1,1,1,1],[1,0,0,0,0,0,1],[1,0,1,1,1,0,1],[1,0,1,0,1,0,1],[1,0,1,1,1,0,1],[1,0,0,0,0,0,1],[1,1,1,1,1,1,1]]", 2},
            new object[] {"[[0,0,1,0,0],[0,1,0,1,0],[0,1,1,0,1],[0,1,1,1,0]]", 2},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string gridStr, int expected)
        {
            var grid = ArrayHelper.MatrixFromString<int>(gridStr);

            var sol = new Solution();
            var res = sol.ClosedIsland(grid);

            Assert.AreEqual(expected, res);
        }
    }
}