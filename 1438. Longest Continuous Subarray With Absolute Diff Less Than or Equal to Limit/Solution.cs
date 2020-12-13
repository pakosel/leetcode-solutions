using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace LongestContinuousSubarrayWithAbsoluteDiffLessThanEqualLimit
{
    public class Solution
    {
        public int LongestSubarray(int[] nums, int limit)
        {
            int res = 0;
            int left = 0;
            int right = 0;
            int currMax = nums[0];
            int currMin = nums[0];
            while (right < nums.Length)
            {
                currMax = Math.Max(currMax, nums[right]);
                currMin = Math.Min(currMin, nums[right]);
                if (currMax - currMin <= limit)
                {
                    res = Math.Max(res, right - left + 1);
                }
                else
                {
                    left = right;
                    currMax = nums[right];
                    currMin = nums[right];

                    while (Math.Abs(nums[right] - nums[left - 1]) <= limit)
                    {
                        left--;
                        currMax = Math.Max(currMax, nums[left]);
                        currMin = Math.Min(currMin, nums[left]);
                    }
                }
                right++;
            }
            return res;
        }
    }
}