using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MergeSortedArray
{
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int idx = m + n - 1;
            m--;
            n--;
            while (m >= 0 && n >= 0)
                nums1[idx--] = (nums1[m] > nums2[n] ? nums1[m--] : nums2[n--]);

            while (n >= 0)
                nums1[idx--] = nums2[n--];
        }
    }
}