using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace KRadiusSubarrayAverages
{
    public class Solution
    {
        public int[] GetAverages(int[] nums, int k)
        {
            if (k == 0)
                return nums;

            var n = nums.Length;
            var res = new int[n];
            Array.Fill(res, -1);
            var dest = k;
            var left = 0;
            var right = -1;
            long sum = 0;

            while (++right < n)
            {
                sum += nums[right];
                if (right - left == 2 * k)
                {
                    res[dest++] = (int)(sum / (2 * k + 1));
                    sum -= nums[left++];
                }
            }
            return res;
        }
    }
}