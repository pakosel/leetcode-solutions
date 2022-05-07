using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MinimumAverageDifference
{
    public class Solution
    {
        public int MinimumAverageDifference(int[] nums)
        {
            var len = nums.Length;

            long right = nums.Sum(_ => (long)_);
            long left = 0;
            var cnt = 0;
            long min = Math.Abs(right / len);
            var idx = len - 1;
            for (int i = 0; i < len - 1; i++)
            {
                cnt++;
                left += nums[i];
                right -= nums[i];
                var abs = Math.Abs(left / cnt - right / (len - cnt));
                if (abs < min || (i < idx && abs == min))
                {
                    min = abs;
                    idx = i;
                }
            }
            return idx;
        }
    }
}