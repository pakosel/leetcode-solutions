using System.Collections.Generic;
using System.Linq;
using System;

namespace BestTimeToBuyStock
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            var buy = prices[0];
            var res = 0;

            foreach (var p in prices)
            {
                res = Math.Max(res, p - buy);
                buy = Math.Min(buy, p);
            }
            return res;
        }
    }
}