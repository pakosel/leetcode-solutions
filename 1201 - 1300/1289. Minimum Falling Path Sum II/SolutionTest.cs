using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MinimumFallingPathSumII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[1,2,3],[4,5,6],[7,8,9]]", 13},
            new object[] {"[[7]]", 7},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string gridStr, int expected)
        {
            var grid = ArrayHelper.MatrixFromString<int>(gridStr);

            var sol = new Solution();
            var res = sol.MinFallingPathSum(grid);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}