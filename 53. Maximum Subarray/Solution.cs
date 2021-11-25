using System.Collections.Generic;
using System.Linq;
using System;

namespace MaximumSubarray
{
    public class Solution
    {
        public int MaxSubArray(int[] nums)
        {
            var res = nums[0];
            var max = res;
            var i = 0;
            while (++i < nums.Length)
            {
                if (res < 0)
                    res = nums[i];
                else
                    res += nums[i];
                max = Math.Max(max, res);
            }
            return max;
        }
    }
}