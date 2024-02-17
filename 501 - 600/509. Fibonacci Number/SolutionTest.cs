using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace FibonacciNumber
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {1, 1},
            new object[] {2, 1},
            new object[] {3, 2},
            new object[] {4, 3},
            new object[] {5, 5},
            new object[] {7, 13},
            new object[] {13, 233},
            new object[] {16, 987},
            new object[] {30, 832040},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int n, int expected)
        {
            var sol = new Solution();
            var res = sol.Fib(n);

            Assert.That(expected == res);
        }
    }
}