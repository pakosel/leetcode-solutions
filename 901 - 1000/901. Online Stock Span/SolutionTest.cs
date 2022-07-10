using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace OnlineStockSpan
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[[100], [80], [60], [70], [60], [75], [85]]", "[1, 1, 1, 2, 1, 4, 6]"},
            new object[] {"[[1],[1],[1],[1],[10],[9],[8],[7],[6],[5],[4],[3]]", "[1,2,3,4,5,1,1,1,1,1,1,1]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string pricesStr, string expectedStr)
        {
            var sol = new StockSpanner();
            var prices = ArrayHelper.MatrixFromString<int>(pricesStr);
            var res = new int[prices.Length];
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            Assert.AreEqual(prices.Length, expected.Length);

            for(int i=0; i<prices.Length; i++)
                res[i] = sol.Next(prices[i][0]);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}