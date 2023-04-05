using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MinimizeMaximumOfArray
{
    public class Solution
    {
        public int MinimizeArrayValue(int[] nums)
        {
            int res = nums[0];
            long sum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                sum += nums[i];
                res = Math.Max(res, (int)Math.Ceiling(sum / (i + 1.0)));
            }

            return res;
        }
    }
}