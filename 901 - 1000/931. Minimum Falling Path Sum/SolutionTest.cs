using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MinimumFallingPathSum
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[1]]", 1},
            new object[] {"[[2,1,3],[6,5,4],[7,8,9]]", 13},
            new object[] {"[[-19,57],[-40,-5]]", -59},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Memoization(string matrixStr, int expected)
        {
            var matrix = ArrayHelper.MatrixFromString<int>(matrixStr);

            var sol = new Solution();
            var res = sol.MinFallingPathSum(matrix);

            Assert.That(expected == res);
        }
    }
}