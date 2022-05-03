using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ShortestUnsortedContinuousSubarray
{
    public class Solution
    {
        public int FindUnsortedSubarray(int[] nums)
        {
            var len = nums.Length;
            var left = 0;
            var increasing = true;
            for (int i = 1; i < len; i++)
                if (increasing && nums[i] >= nums[left])
                    left = i;
                else
                {
                    while (left >= 0 && nums[left] > nums[i])
                        left--;
                    increasing = false;     //from now on - we can only decrement left pointer
                }

            if (left == len - 1)
                return 0;

            var decreasing = true;
            int right = len - 1;
            for (int i = len - 2; i > left; i--)
                if (decreasing && nums[right] >= nums[i])
                    right = i;
                else
                {
                    while (right < len && nums[right] < nums[i])
                        right++;
                    decreasing = false;     //from now on - we can only increment right pointer
                }

            left++;
            right--;
            return right - left + 1;
        }
    }
}