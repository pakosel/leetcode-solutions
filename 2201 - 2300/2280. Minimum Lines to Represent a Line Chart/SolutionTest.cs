using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MinimumLinesToRepresentLineChart
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[1,1]]", 0},
            new object[] {"[[1,7],[2,6],[3,5],[4,4],[5,4],[6,3],[7,2],[8,1]]", 3},
            new object[] {"[[3,4],[1,2],[7,8],[2,3]]", 1},
            new object[] {"[[1,7],[2,6],[3,5],[4,4],[5,4],[6,3],[7,2],[8,1]]", 3},
            new object[] {"[[3,4],[1,2],[7,8],[2,3]]", 1},
            new object[] {"[[3,387],[5,645],[12,1548],[17,2193]]", 1},
            new object[] {"[[1,1],[500000000,499999999],[1000000000,999999998]]", 2},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string stockPricesStr, int expected)
        {
            var stockPrices = ArrayHelper.MatrixFromString(stockPricesStr);

            var sol = new Solution();
            var res = sol.MinimumLines(stockPrices);

            Assert.AreEqual(expected, res);
        }
    }
}