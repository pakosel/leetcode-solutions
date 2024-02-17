using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaximumValueAtGivenIndexInBoundedArray
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {4, 2, 6, 2},
            new object[] {6, 1, 10, 3},
            new object[] {100000000, 77777777, 1000000000, 30001},
            new object[] {2, 1, 529635016, 264817508},
            new object[] {10, 7, 1000000000, 100000003},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(int n, int index, int maxSum, int expected)
        {
            var sol = new Solution();
            var res = sol.MaxValue(n, index, maxSum);

            Assert.That(expected == res);
        }
    }
}