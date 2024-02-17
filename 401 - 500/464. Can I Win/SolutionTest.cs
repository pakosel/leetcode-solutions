using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CanIWin
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {10, 11, false},
            new object[] {10, 0, true},
            new object[] {10, 1, true},
            new object[] {10, 1, true},
            new object[] {10, 2, true},
            new object[] {10, 3, true},
            new object[] {10, 4, true},
            new object[] {10, 5, true},
            new object[] {10, 6, true},
            new object[] {10, 7, true},
            new object[] {10, 8, true},
            new object[] {10, 9, true},
            new object[] {10, 10, true},
            new object[] {10, 11, false},
            new object[] {10, 13, true},
            new object[] {10, 14, true},
            new object[] {10, 15, true},
            new object[] {10, 12, true},
            new object[] {1, 300, false},
            new object[] {2, 300, false},
            new object[] {3, 300, false},
            new object[] {20, 210, false},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int maxChoosableInteger, int desiredTotal, bool expected)
        {
            var sol = new Solution();
            var res = sol.CanIWin(maxChoosableInteger, desiredTotal);

            Assert.That(expected == res);
        }
    }
}