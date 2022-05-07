using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace PartitionArrayIntoDisjointIntervals
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,2]", 1},
            new object[] {"[5,0,3,8,6]", 3},
            new object[] {"[1,1,1,0,6,12]", 4},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Memoization(string arrStr, int expected)
        {
            var nums = ArrayHelper.ArrayFromString(arrStr);

            var sol = new Solution();
            var res = sol.PartitionDisjoint(nums);

            Assert.AreEqual(res, expected);
        }
    }
}