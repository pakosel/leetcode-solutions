using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace BestTimeToBuyStock
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[7,1,5,3,6,4]", 5},
            new object[] {"[7,6,4,3,1]", 0},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Example(string pricesStr, int expected)
        {
            var prices = ArrayHelper.ArrayFromString<int>(pricesStr);

            var sol = new Solution();
            var ret = sol.MaxProfit(prices);

            ClassicAssert.AreEqual(ret, expected);
        }
    }
}