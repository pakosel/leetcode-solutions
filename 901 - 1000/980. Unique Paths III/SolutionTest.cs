using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace UniquePathsIII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[1,0,0,0],[0,0,0,0],[0,0,2,-1]]", 2},
            new object[] {"[[1,0,0,0],[0,0,0,0],[0,0,0,2]]", 4},
            new object[] {"[[0,1],[2,0]]", 0},
            new object[] {"[[1,0,0,0,0],[0,0,0,0,0],[0,0,0,0,0],[0,0,0,0,2]]", 20},
            new object[] {"[[-1,0,0,0,0],[0,0,1,0,0],[0,0,0,0,0],[0,0,0,0,2]]", 4},
            new object[] {"[[0,0,0,0,0],[0,0,1,0,0],[0,0,2,0,0],[0,0,0,0,0]]", 6},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string gridStr, int expected)
        {
            var grid = ArrayHelper.MatrixFromString<int>(gridStr);

            var sol = new Solution();
            var res = sol.UniquePathsIII(grid);

            Assert.That(expected == res);
        }
    }
}