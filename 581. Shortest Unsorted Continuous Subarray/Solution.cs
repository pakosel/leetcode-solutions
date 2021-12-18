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
            var isSet = true;
            for (int i = 1; i < len; i++)
                if (!isSet && nums[i] >= nums[left])
                    left = i;
                else
                {
                    while (left >= 0 && nums[left] > nums[i])
                        left--;
                    isSet = true;
                }

            if (left == len - 1)
                return 0;

            isSet = false;
            int right = len - 1;
            for (int i = len - 2; i > left; i--)
                if (!isSet && nums[right] >= nums[i])
                    right = i;
                else
                {
                    while (right < len && nums[right] < nums[i])
                        right++;
                    isSet = true;
                }

            left++;
            right--;
            return right - left + 1;
        }
    }
}