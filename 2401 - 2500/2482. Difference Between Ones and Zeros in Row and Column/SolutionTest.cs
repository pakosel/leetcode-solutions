using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace DifferenceBetweenOnesAndZerosInRowAndColumn
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[0,1,1],[1,0,1],[0,0,1]]", "[[0,0,4],[0,0,4],[-2,-2,2]]"},
            new object[] {"[[1,1,1],[1,1,1]]", "[[5,5,5],[5,5,5]]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string gridStr, string expectedStr)
        {
            var grid = ArrayHelper.MatrixFromString<int>(gridStr);
            var expected = ArrayHelper.MatrixFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.OnesMinusZeros(grid);

            Assert.That(res, Is.EqualTo(expected));
        }
    }
}