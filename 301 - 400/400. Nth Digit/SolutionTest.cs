using System;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace NthDigit
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {0, 0},
            new object[] {1, 1},
            new object[] {2, 2},
            new object[] {3, 3},
            new object[] {11, 0},
            new object[] {1000, 3},
            new object[] {1000000000, 1},
            new object[] {2147483646, 2},
            new object[] {2147483647, 2},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int input, int expected)
        {
            var sol = new Solution();
            var res = sol.FindNthDigit(input);

            Assert.That(expected == res);
        }
    }
}
