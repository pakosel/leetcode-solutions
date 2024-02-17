using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ShortestBridge
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[0,1],[1,0]]", 1},
            new object[] {"[[0,1,0],[0,0,0],[0,0,1]]", 2},
            new object[] {"[[1,1,1,1,1],[1,0,0,0,1],[1,0,1,0,1],[1,0,0,0,1],[1,1,1,1,1]]", 1},
            new object[] {"[[1,1,1,0,1,1],[1,1,1,1,0,1],[1,1,1,0,1,1],[1,1,0,0,1,1],[1,1,0,1,0,1],[1,1,1,1,0,1]]", 1}
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string matrixStr, int expected)
        {
            var grid = ArrayHelper.MatrixFromString<int>(matrixStr);

            var sol = new Solution();
            var res = sol.ShortestBridge(grid);

            Assert.That(expected == res);
        }
    }
}