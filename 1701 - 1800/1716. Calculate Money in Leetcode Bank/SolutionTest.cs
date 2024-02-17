using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CalculateMoneyInLeetcodeBank
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {1, 1},
            new object[] {2, 3},
            new object[] {3, 6},
            new object[] {4, 10},
            new object[] {10, 37},
            new object[] {20, 96},
            new object[] {13, 55},
            new object[] {14, 63},
            new object[] {15, 66},
            new object[] {21, 105},
            new object[] {99, 1044},
            new object[] {700, 37450},
            new object[] {1000, 74926},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(int n, int expected)
        {
            var sol = new Solution();
            var res = sol.TotalMoney(n);

            Assert.That(expected == res);
        }
    }
}