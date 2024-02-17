using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace UniquePaths
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {1, 1, 1},
            new object[] {2, 1, 1},
            new object[] {7, 1, 1},
            new object[] {1, 2, 1},
            new object[] {1, 7, 1},
            new object[] {3, 7, 28},
            new object[] {7, 3, 28},
            new object[] {3, 2, 3},
            new object[] {3, 2, 3},
            new object[] {3, 3, 6},
            new object[] {7, 7, 924},
            new object[] {10, 10, 48620},
            new object[] {23, 12, 193536720},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int m, int n, int expected)
        {
            var sol = new Solution();
            var res = sol.UniquePaths(m, n);

            Assert.That(expected == res);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_2021(int m, int n, int expected)
        {
            var sol = new Solution_2021();
            var res = sol.UniquePaths(m, n);

            Assert.That(expected == res);
        }
    }
}