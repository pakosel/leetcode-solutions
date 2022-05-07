using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace SlidingWindowMaximum
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {new int[] {1}, 1, new int[] {1}},
            new object[] {new int[] {1,3,-1,-3,5,3,6,7}, 3, new int[] {3,3,5,5,6,7}},
            new object[] {new int[] {1,2,3,4,5,6,7}, 3, new int[] {3,4,5,6,7}},
            new object[] {new int[] {1,2,3,4,5,6,7}, 2, new int[] {2,3,4,5,6,7}},
            new object[] {new int[] {7,6,5,4,3,2,1}, 2, new int[] {7,6,5,4,3,2}},
            new object[] {new int[] {7,6,5,4,3,2,1}, 4, new int[] {7,6,5,4}},
            new object[] {new int[] {1,7,2,6,4,1,2,1,3}, 3, new int[] {7,7,6,6,4,2,3}},
            new object[] {new int[] {1,1,1,1,1,1}, 2, new int[] {1,1,1,1,1}},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int[] nums, int k, int[] expected)
        {
            var sol = new Solution();
            var res = sol.MaxSlidingWindow(nums, k);

            CollectionAssert.AreEqual(res, expected);
        }
    }
}