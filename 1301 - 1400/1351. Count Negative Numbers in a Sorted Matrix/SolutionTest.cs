using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CountNegativeNumbersInSortedMatrix
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[4,3,2,-1],[3,2,1,-1],[1,1,-1,-2],[-1,-1,-2,-3]]", 8},
            new object[] {"[[3,2],[1,0]]", 0},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string gridStr, int expected)
        {
            var grid = ArrayHelper.MatrixFromString<int>(gridStr);

            var sol = new Solution();
            var res = sol.CountNegatives(grid);

            Assert.AreEqual(expected, res);
        }
    }
}