using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace PowerOfTwo
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {0, false },
            new object[] {1, true },
            new object[] {2, true },
            new object[] {3, false },
            new object[] {16, true },
            new object[] {24, false },
            new object[] {32, true },
            new object[] {128, true },
            new object[] {-256, false },
            new object[] {2147483647, false },
            new object[] {-2147483648, false },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Stack(int n, bool expected)
        {
            var sol = new Solution();
            var res = sol.IsPowerOfTwo(n);

            Assert.AreEqual(expected, res);
        }
    }
}