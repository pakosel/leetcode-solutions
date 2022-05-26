using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace KthLargestElementInAnArray
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1,2,3,4,4,4]", 3, 4},
            new object[] {"[1,2,3,4,4,4]", 4, 3},
            new object[] {"[3,2,1,5,6,4]", 2, 5},
            new object[] {"[3,2,3,1,2,4,5,5,6]", 4, 4},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_GenericStr(string numsStr, int k, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution();
            var res = sol.FindKthLargest(nums, k);

            Assert.AreEqual(res, expected);
        }
    }
}