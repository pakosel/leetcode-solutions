using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace RemoveDuplicatesFromSortedArrayII
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int i = 1;
            int j = 2;
            while (j < nums.Length)
            {
                if (nums[i] == nums[j] && nums[i - 1] == nums[j])
                    j++;
                else
                    nums[++i] = nums[j++];
            }
            return Math.Min(nums.Length, i + 1);
        }
    }
}