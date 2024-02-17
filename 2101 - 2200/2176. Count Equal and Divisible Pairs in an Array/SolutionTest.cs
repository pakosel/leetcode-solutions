using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CountEqualAndDivisiblePairsInAnArray
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[3,1,2,2,2,1,3]", 2, 4},
            new object[] {"[1,2,3,4]", 1, 0},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, int k, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution();
            var res = sol.CountPairs(nums, k);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}