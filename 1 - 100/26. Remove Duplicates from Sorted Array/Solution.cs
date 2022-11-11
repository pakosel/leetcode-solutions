using System.Collections.Generic;
using System.Linq;
using System;

namespace RemoveDuplicatesFromSortedArray
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int pos = 0;
            for (int i = 1; i < nums.Length; i++)
                if (nums[pos] != nums[i])
                    nums[++pos] = nums[i];
            return pos + 1;
        }
    }
}