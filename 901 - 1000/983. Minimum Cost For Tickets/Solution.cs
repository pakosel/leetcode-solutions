using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MinimumCostForTickets
{
    public class Solution
    {
        public int MincostTickets(int[] days, int[] costs)
        {
            var memo = new Dictionary<int, int>();

            return Min(0, 0);

            int Min(int idx, int lastDay)
            {
                if (idx == days.Length)
                    return 0;
                if (lastDay >= days[idx])
                    return Min(idx + 1, lastDay);
                if (memo.ContainsKey(idx))
                    return memo[idx];

                //need to buy a ticket
                var cost1 = costs[0] < costs[1] ? costs[0] + Min(idx + 1, days[idx]) : int.MaxValue;
                var cost7 = costs[1] < costs[2] ? costs[1] + Min(idx + 1, days[idx] + 6) : int.MaxValue;
                var cost30 = costs[2] + Min(idx + 1, days[idx] + 29);

                var res = Math.Min(cost1, Math.Min(cost7, cost30));

                memo.Add(idx, res);

                return res;
            }
        }
    }
}