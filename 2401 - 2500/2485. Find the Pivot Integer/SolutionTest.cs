using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FindThePivotInteger
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {8, 6},
            new object[] {1, 1},
            new object[] {4, -1},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(int n, int expected)
        {
            var sol = new Solution();
            var res = sol.PivotInteger(n);

            Assert.That(expected == res);
        }
    }
}