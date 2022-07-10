using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace ThekthFactorOfN
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {1, 1, 1},
            new object[] {7, 2, 7},
            new object[] {12, 3, 3},
            new object[] {4, 4, -1},
            new object[] {1000, 3, 4},
            new object[] {1000, 12, 125},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(int n, int k, int expected)
        {
            var sol = new Solution();
            var res = sol.KthFactor(n, k);

            Assert.AreEqual(expected, res);
        }
    }
}