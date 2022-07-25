using System.Collections.Generic;
using System.Linq;
using System;

namespace PositionsInSortedArray
{
    public class Solution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            var pos = Array.BinarySearch(nums, target);
            if (pos < 0)
                return new int[] { -1, -1 };
            var start = pos;
            var end = pos;
            while (start - 1 >= 0 && nums[start - 1] == target)
                start--;
            while (end + 1 < nums.Length && nums[end + 1] == target)
                end++;
            return new int[] { start, end };
        }
    }
}