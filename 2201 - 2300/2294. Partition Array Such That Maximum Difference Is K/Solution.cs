using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace PartitionArraySuchThatMaximumDifferenceIsK
{
    public class Solution
    {
        public int PartitionArray(int[] nums, int k)
        {
            Array.Sort(nums);
            var curr = nums[0];
            var res = 1;
            foreach (var n in nums)
                if (n - curr > k)
                {
                    res++;
                    curr = n;
                }
            return res;
        }
    }
}