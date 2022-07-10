using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace PowerOfFour
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {0, false },
            new object[] {1, true },
            new object[] {-1, false },
            new object[] {2, false },
            new object[] {3, false },
            new object[] {5, false },
            new object[] {4, true },
            new object[] {8, false },
            new object[] {16, true },
            new object[] {-16, false },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Stack(int n, bool expected)
        {
            var sol = new Solution();
            var res = sol.IsPowerOfFour(n);

            Assert.AreEqual(expected, res);
        }
    }
}