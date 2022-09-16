using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MaximumScoreFromPerformingMultiplicationOperations
{
    public class Solution
    {
        public int MaximumScore(int[] nums, int[] multipliers)
        {
            var memo = new Dictionary<(int left, int right, int i), int>();

            return Max(0, nums.Length - 1, 0);

            int Max(int left, int right, int i)
            {
                if (memo.ContainsKey((left, right, i)))
                    return memo[(left, right, i)];

                var res = 0;
                if (i == multipliers.Length - 1)
                    res = Math.Max(multipliers[i] * nums[left], multipliers[i] * nums[right]);
                else
                    res = Math.Max(multipliers[i] * nums[left] + Max(left + 1, right, i + 1),
                                   multipliers[i] * nums[right] + Max(left, right - 1, i + 1));

                memo.Add((left, right, i), res);

                return res;
            }
        }
    }
}