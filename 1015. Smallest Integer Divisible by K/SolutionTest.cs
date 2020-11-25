using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SmallestIntegerDivisibleByK
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {1, 1},
            new object[] {2, -1},
            new object[] {11, 2},
            new object[] {3, 3},
            new object[] {35463, 11820},
            new object[] {95463, 95454},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int K, int expected)
        {
            var sol = new Solution();
            var res = sol.SmallestRepunitDivByK(K);

            Assert.AreEqual(res, expected);
        }
    }
}