using System.Collections.Generic;
using System.Linq;
using System;

namespace HouseRobber2
{
    public class Solution
    {
        public int Rob(int[] nums)
        {
            int len = nums.Length;
            if(len == 0)
                return 0;
            if(len == 1)
                return nums[0];
            if(len == 2)
                return Math.Max(nums[0], nums[1]);

            int last = nums[len - 1];
            nums[len-1] = 0;
            int max = Rob_noCycle(nums);
            nums[len-1] = last;
            nums[0] = 0;
            max = Math.Max(max, Rob_noCycle(nums));

            return max;
        }

        public int Rob_noCycle(int[] nums)
        {
            int len = nums.Length;

            int max_minus2 = nums[0];
            int max_minus1 = Math.Max(nums[1], nums[0]);
            int max_current = 0;

            for(int i=2; i<len; i++)
            {
                max_current = Math.Max(max_minus1, max_minus2+nums[i]);
                max_minus2 = max_minus1;
                max_minus1 = max_current;
            }

            return max_current;
        }
    }
}