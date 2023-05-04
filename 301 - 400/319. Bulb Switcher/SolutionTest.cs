using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace BulbSwitcher
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {0, 0},
            new object[] {1, 1},
            new object[] {2, 1},
            new object[] {3, 1},
            new object[] {7, 2},
            new object[] {11, 3},
            new object[] {12, 3},
            new object[] {13, 3},
            new object[] {14, 3},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int n, int expected)
        {
            var sol = new Solution();
            var res = sol.BulbSwitch(n);

            Assert.AreEqual(expected, res);
        }
    }
}