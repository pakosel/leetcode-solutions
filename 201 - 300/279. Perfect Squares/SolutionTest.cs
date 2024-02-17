using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace PerfectSquares
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {1, 1},
            new object[] {2, 2},
            new object[] {3, 3},
            new object[] {12, 3},
            new object[] {13, 2},
            new object[] {654, 3},
            new object[] {256, 1},
            new object[] {1024, 1},
            new object[] {525, 3},
            new object[] {9999, 4},
            new object[] {10000, 1},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int n, int expected)
        {
            var sol = new Solution();
            var res = sol.NumSquares(n);

            Assert.That(expected == res);
        }
    }
}