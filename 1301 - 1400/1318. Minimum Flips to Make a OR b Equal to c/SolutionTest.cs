using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MinimumFlips
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {2, 6, 5, 3},
            new object[] {4, 2, 7, 1},
            new object[] {1, 2, 3, 0},
            new object[] {2987, 624, 58979, 9},
            new object[] {11111111, 88888888, 999999, 12},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(int a, int b, int c, int expected)
        {
            var sol = new Solution();
            var res = sol.MinFlips(a, b, c);

            Assert.That(expected == res);
        }
    }
}