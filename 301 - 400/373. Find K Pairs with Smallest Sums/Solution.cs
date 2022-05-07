using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace FindPairsWithSmallestSums
{
    public class Solution
    {
        public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k)
        {
            int len1 = nums1.Length;
            int len2 = nums2.Length;
            int idx = 0;

            int[][] arr = new int[len1 * len2][];
            for (int i = 0; i < len1; i++)
                for (int j = 0; j < len2; j++)
                    arr[idx++] = new int[] { nums1[i], nums2[j] };
            Array.Sort(arr, (e1, e2) => (e1[0] + e1[1]).CompareTo(e2[0] + e2[1]));

            idx = 0;
            IList<IList<int>> res = new List<IList<int>>();
            while (k > 0 && idx < arr.Length)
            {
                res.Add(arr[idx]);
                k--;
                idx++;
            }

            return res;
        }
    }
}