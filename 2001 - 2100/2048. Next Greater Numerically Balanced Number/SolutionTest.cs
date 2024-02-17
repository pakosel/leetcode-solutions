using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace NextGreaterNumericallyBalancedNumber
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {1, 22},
            new object[] {1000, 1333},
            new object[] {3000, 3133},
            new object[] {250, 333},
            new object[] {248652, 312233},
            new object[] {1000000, 1224444},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(int n, int expected)
        {
            var sol = new Solution();
            var res = sol.NextBeautifulNumber(n);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}