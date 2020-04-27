using System.Collections.Generic;
using System.Linq;
using System;

namespace BestTimeToBuyStock
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            var len = prices.Length;
            if (len < 2)
                return 0;
            int min = prices[0];
            int max = prices[1];
            int maxGain = 0;

            for (int i = 1; i < len; i++)
            {
                var price = prices[i];
                if (price < min)
                {
                    maxGain = Math.Max(maxGain, max - min);
                    min = price;
                    max = -1;
                }
                else if (price > max)
                    max = price;
            }

            return Math.Max(maxGain, max - min);
        }
    }
}