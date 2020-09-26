using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace MinimumSizeSubarraySum
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {0, "[]", 0},
            new object[] {7, "[]", 0},
            new object[] {7, "[2,3,1,2,4,3]", 2},
            new object[] {2, "[1,2]", 1},
            new object[] {1, "[1,2]", 1},
            new object[] {3, "[1,2]", 2},
            new object[] {5, "[1,2]", 0},
            new object[] {9, "[2,3,10,2,4,3]", 1},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Example(int s, string input, int expected)
        {
            int[] nums;
            if(input.Contains(','))
            {
                var numsStr = input.TrimStart('[').TrimEnd(']').Split(',');
                nums = new int[numsStr.Length];
                for(int i=0; i<numsStr.Length; i++)
                    nums[i] = int.Parse(numsStr[i]);
            }
            else
                nums = new int[0];

            var sol = new Solution();
            var ret = sol.MinSubArrayLen(s, nums);

            Assert.AreEqual(ret, expected);
        }
    }
}