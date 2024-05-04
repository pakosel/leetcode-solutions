using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace NthTribonacciNumber
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {0, 0},
            new object[] {1, 1},
            new object[] {2, 1},
            new object[] {3, 2},
            new object[] {4, 4},
            new object[] {5, 7},
            new object[] {25, 1389537},
            new object[] {32, 98950096},
            new object[] {37, 2082876103},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int n, int expected)
        {
            var sol = new Solution();
            var res = sol.Tribonacci(n);

            Assert.That(expected == res);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic24(int n, int expected)
        {
            var sol = new Solution2024();
            var res = sol.Tribonacci(n);

            Assert.That(expected == res);
        }
    }
}