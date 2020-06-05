using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Collections;

namespace LongestIncreasingSubsequence
{
    public class Solution
    {
        Dictionary<int, int> memo = new Dictionary<int, int>();
        public int LengthOfLIS(int[] nums)
        {
            if(nums.Length == 0)
                return 0;
                
            int res = 1;
            for (int i = 0; i < nums.Length; i++)
                res = Math.Max(res, Helper(nums, i));

            return res;
        }
        private int Helper(int[] nums, int start)
        {
            if (memo.ContainsKey(start))
                return memo[start];

            int res = 1;
            for (int i = start + 1; i < nums.Length; i++)
                if (nums[i] > nums[start])
                    res = Math.Max(res, 1 + Helper(nums, i));

            memo.Add(start, res);
            return res;
        }
    }
}