using System.Collections.Generic;
using System.Linq;
using System;

namespace HouseRobber
{
    public class Solution_2022
    {
        public int Rob(int[] nums)
        {
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                var next = i + 2 < nums.Length ? nums[i + 2] : 0;
                nums[i] = Math.Max(nums[i] + next, nums[i + 1]);
            }
            return nums[0];
        }
    }

    public class Solution
    {
        public int Rob(int[] nums)
        {
            int len = nums.Length;
            if (len == 0)
                return 0;
            if (len == 1)
                return nums[0];
            if (len == 2)
                return Math.Max(nums[0], nums[1]);

            int max_minus2 = nums[0];
            int max_minus1 = Math.Max(nums[1], nums[0]);
            int max_current = 0;

            for (int i = 2; i < len; i++)
            {
                max_current = Math.Max(max_minus1, max_minus2 + nums[i]);
                var tmp = max_minus2;
                max_minus2 = max_minus1;
                max_minus1 = max_current;
            }

            return max_current;
        }
    }
}