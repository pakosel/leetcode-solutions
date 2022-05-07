using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MinimumCostOfBuyingCandiesWithDiscount
{
    public class Solution
    {
        public int MinimumCost(int[] cost)
        {
            var len = cost.Length;
            if (len < 3)
                return cost.Sum();

            Array.Sort(cost);
            var res = 0;
            int i = len - 1;
            while (i > 1)
            {
                res += cost[i--];
                res += cost[i--];
                i--;
            }
            while (i >= 0)
                res += cost[i--];
            return res;
        }
    }
}