using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace NthMagicalNumber
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {1, 2, 3, 2},
            new object[] {4, 2, 3, 6},
            new object[] {6, 2, 3, 9},
            new object[] {15, 2, 3, 22},
            new object[] {5, 2, 4, 10},
            new object[] {3, 6, 4, 8},
            new object[] {887859796, 29911, 37516, 257511204},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Memoization(int n, int a, int b, int expected)
        {
            var sol = new Solution();
            var res = sol.NthMagicalNumber(n, a, b);

            Assert.AreEqual(expected, res);
        }
    }
}