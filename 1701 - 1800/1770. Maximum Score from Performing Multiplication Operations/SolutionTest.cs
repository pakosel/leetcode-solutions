using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaximumScoreFromPerformingMultiplicationOperations
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,2,3]","[3,2,1]", 14},
            new object[] {"[-5,-3,-3,-2,7,1]","[-10,-5,3,4,6]", 102},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, string multipliersStr, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            var multipliers = ArrayHelper.ArrayFromString<int>(multipliersStr);

            var sol = new Solution();
            var res = sol.MaximumScore(nums, multipliers);

            Assert.AreEqual(expected, res);
        }
    }
}