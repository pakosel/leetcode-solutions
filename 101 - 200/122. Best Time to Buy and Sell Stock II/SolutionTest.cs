using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace BestTimeToBuyStockII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[0]", 0},
            new object[] {"[7,1,5,3,6,4]", 7},
            new object[] {"[1,2,3,4,5]", 4},
            new object[] {"[7,6,4,3,1]", 0},
            new object[] {"[2,1]", 0},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string arrayStr, int expected)
        {
            var prices = ArrayHelper.ArrayFromString<int>(arrayStr);

            var sol = new Solution();
            var ret = sol.MaxProfit(prices);

            Assert.AreEqual(ret, expected);
        }
    }
}