using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace PartitionArrayIntoDisjointIntervals
{
    public class Solution
    {
        public int PartitionDisjoint(int[] nums)
        {
            var len = nums.Length;
            var mins = new int[len];
            var min = nums[len - 1];
            for (int i = len - 1; i > 0; i--)
            {
                min = Math.Min(min, nums[i]);
                mins[i] = min;
            }

            var max = nums[0];
            for (int i = 1; i < len; i++)
            {
                if (max <= mins[i])
                    return i;
                max = Math.Max(max, nums[i]);
            }

            return -1;
        }
    }
}