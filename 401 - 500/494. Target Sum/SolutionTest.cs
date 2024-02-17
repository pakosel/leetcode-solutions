using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace TargetSum
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "[1]", 1, 1 },
            new object[] { "[1]", 2, 0 },
            new object[] { "[1,0]", 1, 2 },
            new object[] { "[1,1,1,1,1]", 3, 5 },
            new object[] { "[1,2,2]", 3, 1 },
            new object[] { "[1,2,2,5]", 3, 0 },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string input, int S, int expected)
        {
            var numsStr = input.TrimStart('[').TrimEnd(']').Split(',');
            int[] nums = new int[numsStr.Length];
            for(int i=0; i<numsStr.Length; i++)
                nums[i] = int.Parse(numsStr[i]);

            var sol = new Solution();
            var res = sol.FindTargetSumWays(nums, S);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}