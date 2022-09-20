using System.Collections.Generic;
using System.Linq;
using System;

namespace MaximumLengthOfRepeatedSubarray
{
    public class Solution
    {
        public int FindLength(int[] nums1, int[] nums2)
        {
            var res = 0;
            for (int i = 0; i < nums1.Length && (nums1.Length - i) > res; i++)
            {
                var currMax = 0;
                for (int j = 0; j < nums2.Length && (nums2.Length - j) > currMax; j++)
                    currMax = Math.Max(currMax, LongestSame(i, j));
                res = Math.Max(res, currMax);
            }
            return res;

            int LongestSame(int i, int j)
            {
                var res = 0;
                var pos1 = i;
                var pos2 = j;
                while (pos1 < nums1.Length && pos2 < nums2.Length && nums1[pos1++] == nums2[pos2++])
                    res++;
                return res;
            }
        }
    }
}