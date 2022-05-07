using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MaximumDistanceBetweenPairOfValues
{
    public class Solution
    {
        public int MaxDistance(int[] nums1, int[] nums2)
        {
            var max = 0;
            for (int j = 0; j < nums2.Length; j++)
            {
                int left = 0;
                int right = Math.Min(nums1.Length - 1, j);
                while (left <= right)
                {
                    var mid = left + (right - left) / 2;
                    if (nums1[right] > nums2[j])
                        break;
                    else if (nums1[mid] <= nums2[j])
                    {
                        max = Math.Max(max, j - mid);
                        right = mid - 1;
                    }
                    else
                        left = mid + 1;
                }
            }
            return max;
        }
    }
}