using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ComplementOfBase10Integer
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {0, 1},
            new object[] {1, 0},
            new object[] {2, 1},
            new object[] {3, 0},
            new object[] {4, 3},
            new object[] {5, 2},
            new object[] {6, 1},
            new object[] {7, 0},
            new object[] {8, 7},
            new object[] {9, 6},
            new object[] {10, 5},
            new object[] {11, 4},
            new object[] {12, 3},
            new object[] {13, 2},
            new object[] {14, 1},
            new object[] {15, 0},
            new object[] {16, 15},
            new object[] {17, 14},
            new object[] {24, 7},
            new object[] {32, 31},
            new object[] {127, 0},
            new object[] {128, 127},
            new object[] {129, 126},
            new object[] {255, 0},
            new object[] {256, 255},
            new object[] {100000, 31071},
            new object[] {10000000, 6777215},
            
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int n, int expected)
        {
            var sol = new Solution();
            var res = sol.BitwiseComplement(n);

            Assert.AreEqual(expected, res);
        }
    }
}