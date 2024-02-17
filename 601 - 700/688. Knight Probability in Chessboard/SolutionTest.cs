using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace KnightProbabilityInChessboard
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {3, 2, 0, 0, 0.06250},
            new object[] {1, 0, 0, 0, 1.00000},
            new object[] {4, 2, 0, 1, 0.15625},
            new object[] {12, 100, 6, 6, 0.00000},
            new object[] {25, 100, 12, 12, 0.04743},
            new object[] {25, 100, 0, 0, 0.00122},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int n, int k, int row, int col, double expected)
        {
            var sol = new Solution();
            var res = sol.KnightProbability(n, k, row, col);

            Assert.That(expected == Math.Round(res, 5));
        }
    }
}