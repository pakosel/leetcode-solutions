using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace NQueensII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {1, 1},
            new object[] {2, 0},
            new object[] {3, 0},
            new object[] {4, 2},
            new object[] {5, 10},
            new object[] {6, 4},
            new object[] {7, 40},
            new object[] {8, 92},
            new object[] {9, 352},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(int n, int expected)
        {
            var sol = new Solution();
            var res = sol.TotalNQueens(n);

            Assert.That(expected == res);
        }
    }
}