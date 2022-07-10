using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace CountPrimes
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {0, 0},
            new object[] {1, 0},
            new object[] {2, 0},
            new object[] {3, 1},
            new object[] {4, 2},
            new object[] {5, 2},
            new object[] {10, 4},
            new object[] {11, 4},
            new object[] {12, 5},
            new object[] {155, 36},
            new object[] {546374, 45052},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int n, int expected)
        {
            var sol = new Solution();
            var res = sol.CountPrimes(n);

            Assert.AreEqual(expected, res);
        }
    }
}