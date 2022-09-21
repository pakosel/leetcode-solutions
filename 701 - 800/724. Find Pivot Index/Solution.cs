using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace FindPivotIndex
{
    public class Solution
    {
        public int PivotIndex(int[] nums)
        {
            var sum = nums.Sum();
            var curr = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum -= nums[i];
                if (sum == curr)
                    return i;
                curr += nums[i];
            }
            return -1;
        }
    }
}