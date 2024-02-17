using System;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace IntegerReplacement
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {1, 0},
            new object[] {2, 1},
            new object[] {3, 2},
            new object[] {4, 2},
            new object[] {5, 3},
            new object[] {6, 3},
            new object[] {7, 4},
            new object[] {8, 3},
            new object[] {9, 4},
            new object[] {10, 4},
            new object[] {11, 5},
            new object[] {13, 5},
            new object[] {1000, 12},
            new object[] {10000, 16},
            new object[] {65535, 17},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int input, int expected)
        {
            var sol = new Solution();
            var res = sol.IntegerReplacement(input);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}
