using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace LongestIncreasingSubsequence
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { new int[] {}, 0 },
            new object[] { new int[] {1}, 1 },
            new object[] { new int[] {10,9,2,5,3,7,101,18}, 4 },
            new object[] { new int[] {10,9,2,5,3,7,101,18,20,22}, 6 },
            new object[] { new int[] {5, 4, 4, 3, 3, 6, 2, 9, 7, 8}, 4 },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int[] nums, int expected)
        {
            var sol = new Solution();
            var res = sol.LengthOfLIS(nums);

            Assert.That(expected == res);
        }
    }
}