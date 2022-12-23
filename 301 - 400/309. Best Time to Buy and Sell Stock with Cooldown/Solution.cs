using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace BestTimeToBuyAndSellStockWithCooldown
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            var len = prices.Length;
            var memo = new int[len];
            Array.Fill(memo, -1);

            return Buy(0);

            int Buy(int start)
            {
                if (start >= len)
                    return 0;
                if (memo[start] != -1)
                    return memo[start];
                var res = 0;
                //find best time to sell if we buy at the start index
                for (int i = start + 1; i < len; i++)
                    res = Math.Max(res, prices[i] - prices[start] + Buy(i + 2));
                
                //IMPORTANT! Check if better to skip this index entirely
                res = Math.Max(res, Buy(start + 1));

                memo[start] = res;
                return res;
            }
        }
    }

}