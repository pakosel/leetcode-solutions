using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CountSubarraysWhereMaxElementAppearsAtLeastKTimes
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[2]", 1, 1},
            new object[] {"[2,2]", 1, 3},
            new object[] {"[2,2,2]", 1, 6},
            new object[] {"[2,2,2,2]", 1, 10},
            new object[] {"[1,1,3,2,3,3,1,2]", 2, 18},
            new object[] {"[1,3,2,3,3]", 2, 6},
            new object[] {"[1,4,2,1]", 3, 0},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, int k, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            
            var sol = new Solution();
            var res = sol.CountSubarrays(nums, k);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}