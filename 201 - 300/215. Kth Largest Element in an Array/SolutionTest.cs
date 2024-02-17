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
            new object[] {"[207,205,214,122,448,16,519,408,493,221,628,596,391,557,747,754,735,122,342,284,269,406,955,695,501,754,22,76,43,357,438,436,295,508,918,754,115,520,144,283,561,378,442,757,609,299,697,645,340,298,487,425,186]", 7, 747},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Solution2022(string numsStr, int k, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution2022();
            var res = sol.FindKthLargest(nums, k);

            Assert.That(expected == res);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Solution(string numsStr, int k, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution();
            var res = sol.FindKthLargest(nums, k);

            Assert.That(expected == res);
        }
    }
}