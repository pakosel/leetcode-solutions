using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace JumpGameII
{
    public class Solution
    {
        public int Jump(int[] nums)
        {
            var len = nums.Length;
            nums[len - 1] = 0;
            for (int i = len - 2; i >= 0; i--)
            {
                var jump = nums[i];
                var min = 100_000_000;
                for (int j = Math.Min(i + nums[i], len - 1); j > i; j--)
                    min = Math.Min(min, nums[j] + 1);
                nums[i] = min;
            }
            return nums[0];
        }
    }
}