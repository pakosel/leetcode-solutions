using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FindTheKBeautyOfNumber
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {1, 1, 1},
            new object[] {240, 2, 2},
            new object[] {430043, 2, 2},
            new object[] {121212, 2, 5},
            new object[] {87351185, 1, 4},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(int num, int k, int expected)
        {
            var sol = new Solution();
            var res = sol.DivisorSubstrings(num, k);

            Assert.That(expected == res);
        }
    }
}