using System;
using System.Text;
using NUnit.Framework;
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
            new object[] {7, 21},
            new object[] {22, 28657},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int n, int expected)
        {
            var sol = new Solution();
            var res = sol.ClimbStairs(n);

            Assert.AreEqual(res, expected);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_DP(int n, int expected)
        {
            var sol = new Solution();
            var res = sol.ClimbStairs_DP(n);

            Assert.AreEqual(res, expected);
        }
    }
}