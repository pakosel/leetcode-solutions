using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MinimizeMaximumPairSumInArray
{
    public class Solution
    {
        public int MinPairSum(int[] nums)
        {
            Array.Sort(nums);
            int left = 0, right = nums.Length - 1;
            var res = 0;
            while (left < right)
                res = Math.Max(res, nums[left++] + nums[right--]);
            return res;
        }
    }
}