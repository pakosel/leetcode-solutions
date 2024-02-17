using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace BestTimeToBuyAndSellStockWithCooldown
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1]", 0},
            new object[] {"[1,2,3,0,2]", 3},
            new object[] {"[1,2,3,0,2]", 3},
            new object[] {"[6,1,2,3,0,5,4,1,2]", 7},
            new object[] {"[5,4,3,2,1]", 0},
            new object[] {"[201,514,677,479,313,880,330,544,170,724,942,367]", 1815},
            new object[] {"[201,514,677,479,313,880,330,544,170,724,942,367,455,973,489,807,641,430,670,235]", 2573},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string pricesStr, int expected)
        {
            var prices = ArrayHelper.ArrayFromString<int>(pricesStr);
            
            var sol = new Solution();
            var res = sol.MaxProfit(prices);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}