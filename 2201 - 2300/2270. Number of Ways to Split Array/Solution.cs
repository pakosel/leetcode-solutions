using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace NumberOfWaysToSplitArray
{
    public class Solution
    {
        public int WaysToSplitArray(int[] nums)
        {
            var res = 0;
            long right = nums.Sum(_ => (long)_);
            long left = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                left += nums[i];
                right -= nums[i];
                if (left >= right)
                    res++;
            }
            return res;
        }
    }
}