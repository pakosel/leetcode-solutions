using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MinCostClimbingStairs
{
    public class Solution
    {
        public int MinCostClimbingStairs(int[] cost)
        {
            var len = cost.Length;
            var memo = new Dictionary<int, int>();

            return Math.Min(Climb(0), Climb(1));

            int Climb(int idx)
            {
                if (idx >= len)
                    return 0;
                if (memo.ContainsKey(idx))
                    return memo[idx];

                var res = cost[idx] + Math.Min(Climb(idx + 1), Climb(idx + 2));
                memo.Add(idx, res);

                return res;
            }
        }
    }
}