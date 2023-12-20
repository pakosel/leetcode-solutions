using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace BuyTwoChocolates
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,2,2]", 3, 0},
            new object[] {"[3,2,3]", 3, 3},
            new object[] {"[1,2,1,2]", 33, 31},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string pricesStr, int money, int expected)
        {
            var prices = ArrayHelper.ArrayFromString<int>(pricesStr);

            var sol = new Solution();
            var res = sol.BuyChoco(prices, money);

            Assert.AreEqual(expected, res);
        }
    }
}