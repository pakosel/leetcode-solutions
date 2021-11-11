using System.Collections.Generic;
using System.Linq;
using System;

namespace MinimumValueToGetPositiveStepByStepSum
{
    public class Solution
    {
        public int MinStartValue(int[] nums)
        {
            int res = 1;
            int sum = res;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                var diff = 1 - sum;
                if (diff > 0)
                {
                    res += diff;
                    sum += diff;
                }
            }
            return res;
        }
    }
}