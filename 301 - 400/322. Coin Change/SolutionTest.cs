using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace CoinChange
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { new int[] {}, 3, -1 },
            new object[] { new int[] {1}, 0, 0 },
            new object[] { new int[] {2,5}, 3, -1 },
            new object[] { new int[] {1,2,5}, 24, 6 },
            new object[] { new int[] {1,2,3,5}, 27, 6 },
            new object[] { new int[] {1,2,3,5}, 25, 5 },
            new object[] { new int[] {186,419,83,408}, 6249, 20 },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int[] coins, int amount, int expected)
        {
            var sol = new Solution();
            var res = sol.CoinChange(coins, amount);

            Assert.AreEqual(res, expected);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Recursive(int[] coins, int amount, int expected)
        {
            var sol = new Solution_Recursive();
            var res = sol.CoinChange(coins, amount);

            Assert.AreEqual(res, expected);
        }
    }
}