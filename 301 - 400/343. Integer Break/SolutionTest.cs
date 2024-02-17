using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace IntegerBreak
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {2, 1},
            new object[] {10, 36},
            new object[] {3, 2},
            new object[] {7, 12},
            new object[] {11, 54},
            new object[] {58, 1549681956},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int n, int expected)
        {
            var sol = new Solution();
            var res = sol.IntegerBreak(n);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}