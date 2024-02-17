using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MinimizedMaximumOfProductsDistributedToAnyStore
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {6, "[11,6]", 3},
            new object[] {7, "[15,10,10]", 5},
            new object[] {1, "[100000]", 100000},
            new object[] {17, "[11,6,5,13,5,15,23,4,1,3]", 7},
            new object[] {173, "[11,6,5,13,5,15,23,4,1,3]", 1},
            new object[] {1731, "[11,6,5,13,5,15,23,4,1,3]", 1},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(int n, string arrStr, int expected)
        {
            var quantities = ArrayHelper.ArrayFromString<int>(arrStr);

            var sol = new Solution();
            var res = sol.MinimizedMaximum(n, quantities);

            Assert.That(expected == res);
        }
    }
}