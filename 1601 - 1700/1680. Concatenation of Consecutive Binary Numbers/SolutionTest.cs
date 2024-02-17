using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ConcatenationOfConsecutiveBinaryNumbers
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {1, 1},
            new object[] {3, 27},
            new object[] {12, 505379714},
            new object[] {122, 996327204},
            new object[] {100000, 757631812},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(int n, int expected)
        {
            var sol = new Solution();
            var res = sol.ConcatenatedBinary(n);

            Assert.That(expected == res);
        }
    }
}