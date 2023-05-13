using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CountWaysToBuildGoodStrings
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {3, 3, 1, 1, 8},
            new object[] {2, 3, 1, 2, 5},
            new object[] {1, 100, 1, 1, 952742561},
            new object[] {7, 100000, 3, 7, 40823901},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(int low, int high, int zero, int one, int expected)
        {
            var sol = new Solution();
            var res = sol.CountGoodStrings(low, high, zero, one);

            Assert.AreEqual(expected, res);
        }
    }
}