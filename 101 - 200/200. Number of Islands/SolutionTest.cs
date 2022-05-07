using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace NumberOfIslands
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[[1]]", 1},
            new object[] {"[[1,0],[0,1]]", 2},
            new object[] {"[[1,1,1,1,0],[1,1,0,1,0],[1,1,0,0,0],[0,0,0,0,0]]", 1},
            new object[] {"[[1,1,0,0,0],[1,1,0,0,0],[0,0,1,0,0],[0,0,0,1,1]]", 3},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string gridStr, int expected)
        {
            var grid = ArrayHelper.CharMatrixFromString(gridStr);

            var sol = new Solution();
            var res = sol.NumIslands(grid);

            Assert.AreEqual(res, expected);
        }
    }
}