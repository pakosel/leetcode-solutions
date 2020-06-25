using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace FindPairsWithSmallestSums
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { new int[] {}, new int[] {}, 3, new int[0][] },
            new object[] { new int[] {1,7,11}, new int[] {2,4,6}, 3, new int[][] {new int[] {1,2}, new int[] {1,4}, new int[] {1,6}} },
            new object[] { new int[] {1,1,2}, new int[] {1,2,3}, 2, new int[][] {new int[] {1,1},new int[] {1,1}} },
            new object[] { new int[] {1,2}, new int[] {3}, 3, new int[][] {new int[] {1,3}, new int[] {2,3}} },
            new object[] { new int[] {1,1,2,3,4,5,6}, new int[] {1,1,1,1,1,1}, 18, new int[][] {new int[] {1,1}, new int[] {1,1}, new int[] {1,1}, new int[] {1,1}, new int[] {1,1}, new int[] {1,1}, new int[] {1,1}, new int[] {1,1}, new int[] {1,1}, new int[] {1,1}, new int[] {1,1}, new int[] {1,1}, new int[] {2,1}, new int[] {2,1}, new int[] {2,1}, new int[] {2,1}, new int[] {2,1}, new int[] {2,1}} },
            new object[] { new int[] {1,1,2}, new int[] {1,2,3}, 10, new int[][] {new int[] {1,1}, new int[] {1,1}, new int[] {2,1}, new int[] {1,2}, new int[] {1,2}, new int[] {2,2}, new int[] {1,3}, new int[] {1,3}, new int[] {2,3}} },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int[] nums1, int[] nums2, int k, IList<IList<int>> expected)
        {
            var sol = new Solution();
            var res = sol.KSmallestPairs(nums1, nums2, k);

            CollectionAssert.AreEquivalent(res, expected);
        }
    }
}