using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CoinChange
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "[1]", 0, 0 },
            new object[] { "[2,5]", 3, -1 },
            new object[] { "[1,2,5]", 24, 6 },
            new object[] { "[1,2,3,5]", 27, 6 },
            new object[] { "[1,2,3,5]", 25, 5 },
            new object[] { "[186,419,83,408]", 6249, 20 },
            new object[] { "[1,2147483647]", 2, 2 },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Dp(string coinsStr, int amount, int expected)
        {
            var coins = ArrayHelper.ArrayFromString(coinsStr);

            var sol = new Solution_DP();
            var res = sol.CoinChange(coins, amount);

            Assert.AreEqual(res, expected);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Recursive(string coinsStr, int amount, int expected)
        {
            var coins = ArrayHelper.ArrayFromString(coinsStr);

            var sol = new Solution_Recursive();
            var res = sol.CoinChange(coins, amount);

            Assert.AreEqual(res, expected);
        }
    }
}