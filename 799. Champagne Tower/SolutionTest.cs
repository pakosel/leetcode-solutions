using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ChampagneTower
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {1, 1, 1, 0.0},
            new object[] {2, 1, 1, 0.5},
            new object[] {100000009, 33, 17, 1.0},
            new object[] {1000000000, 34, 0, 0.0},
            new object[] {1000000000, 34, 1, 0.62552},
            new object[] {1000000000, 34, 2, 1.0},
            new object[] {0, 99, 99, 0.0},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int poured, int row, int glass, double expected)
        {
            var sol = new Solution();
            var res = sol.ChampagneTower(poured, row, glass);

            Assert.AreEqual(Math.Round(res, 5), expected);
        }
    }
}