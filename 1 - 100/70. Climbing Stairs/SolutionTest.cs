using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace ClimbingStairs
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {1, 1},
            new object[] {2, 2},
            new object[] {3, 3},
            new object[] {4, 5},
            new object[] {5, 8},
            new object[] {6, 13},
            new object[] {7, 21},
            new object[] {11, 144},
            new object[] {15, 987},
            new object[] {22, 28657},
            new object[] {25, 121393},
            new object[] {45, 1836311903},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic_2024(int n, int expected)
        {
            var sol = new Solution_2024();
            var res = sol.ClimbStairs(n);

            Assert.That(expected == res);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic_2022(int n, int expected)
        {
            var sol = new Solution_2022();
            var res = sol.ClimbStairs(n);

            Assert.That(expected == res);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int n, int expected)
        {
            var sol = new Solution();
            var res = sol.ClimbStairs(n);

            Assert.That(expected == res);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_DP(int n, int expected)
        {
            var sol = new Solution();
            var res = sol.ClimbStairs_DP(n);

            Assert.That(expected == res);
        }
    }
}