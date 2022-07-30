using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace NumberOfZeroFilledSubarrays
{
    public class Solution
    {
        public long ZeroFilledSubarray(int[] nums)
        {
            long res = 0;
            var left = 0;
            var right = 0;
            while (right < nums.Length)
            {
                while (left < nums.Length && nums[left] != 0)
                    left++;

                right = left;
                while (right < nums.Length && nums[right] == 0)
                    right++;

                long len = right - left;
                res += len * (len + 1) / 2;
                left = right;
            }
            return res;
        }
    }
}