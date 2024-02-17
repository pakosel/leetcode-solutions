using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace RemoveStonesToMinimizeTheTotal
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[5]", 1, 3},
            new object[] {"[5]", 100, 1},
            new object[] {"[5,4,9]", 2, 12},
            new object[] {"[4,3,6,7]", 3, 12},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string pilesStr, int k, int expected)
        {
            var piles = ArrayHelper.ArrayFromString<int>(pilesStr);

            var sol = new Solution();
            var res = sol.MinStoneSum(piles, k);

            Assert.That(expected == res);
        }
    }
}