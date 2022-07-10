using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaximumSubarray
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1]", 1},
            new object[] {"[-2,1,-3,4,-1,2,1,-5,4]", 6},
            new object[] {"[5,4,-1,7,8]", 23},
            new object[] {"[1,2,-2,-3,5,1,1,1,-3,-1,7,2,6,2,-2,-3,5,1,-1,-1,-1,22,-1,-1,-5,-3,-1,7,2,6,2,-2,-3,5,1,1,1,-3,-1,7,2,6,2,-2,-3,5,1,1,1,-3,33,-1,7,2,6,2,-2,-3,5,1,-1,-1,-1,-1,-1,-5,-3,-1,7,2,6,2,-2,-3,5,-1,2]", 117},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string numsStr, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution();
            var res = sol.MaxSubArray(nums);

            Assert.AreEqual(expected, res);
        }
    }
}