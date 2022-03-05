using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace DeleteAndEarn
{
    public class Solution
    {
        Dictionary<int, int> memo = new Dictionary<int, int>();
        List<int> indexes = new List<int>();

        public int DeleteAndEarn(int[] nums)
        {
            Array.Sort(nums);
            indexes.Add(0);
            var curr = nums[0];
            for (int i = 1; i < nums.Length; i++)
                if (nums[i] != curr)
                {
                    indexes.Add(i);
                    curr = nums[i];
                }

            return Math.Max(Helper(nums, 0), Helper(nums, 1));

        }

        private int Helper(int[] nums, int idx)
        {
            var res = 0;
            if (idx >= indexes.Count)
                return res;
            if (memo.ContainsKey(idx))
                return memo[idx];

            var nextVal = (idx == indexes.Count - 1) ? -1 : nums[indexes[idx + 1]];
            var nextIdx = (idx == indexes.Count - 1) ? nums.Length : indexes[idx + 1];
            var currSum = (nextIdx - indexes[idx]) * nums[indexes[idx]];

            if (nextVal == -1 || nextVal - nums[indexes[idx]] > 1)
                res = currSum + Helper(nums, idx + 1);
            else
                res = Math.Max(Helper(nums, idx + 1), currSum + Helper(nums, idx + 2));

            memo.Add(idx, res);
            return res;
        }
    }
}