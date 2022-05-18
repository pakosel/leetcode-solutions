using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MedianOfTwoSortedArrays
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var m = nums1.Length;
            var n = nums2.Length;

            var len = m + n;

            var arr = new int[len];
            int i = 0;

            var i1 = 0;
            var i2 = 0;

            while (i1 < nums1.Length || i2 < nums2.Length)
            {
                var n1 = (i1 < nums1.Length ? nums1[i1] : int.MaxValue);
                var n2 = (i2 < nums2.Length ? nums2[i2] : int.MaxValue);

                if (n1 < n2)
                    arr[i++] = nums1[i1++];
                else
                    arr[i++] = nums2[i2++];
            }

            if (len % 2 == 0)
                return (double)(arr[len / 2] + arr[len / 2 - 1]) / 2;   //take two middle values
            else
                return arr[(len - 1) / 2];     //take one middle value
        }
    }
}