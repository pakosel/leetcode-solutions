using System.Collections.Generic;
using System.Linq;
using System;

namespace BestTimeToBuyStockII
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int len = prices.Length;

            if (len == 1)
                return 0;

            int res = 0;
            int currBuy = prices[0];
            int currSell = prices[1];
            int buyDay = 0;
            for (int i = 1; i < len; i++)
            {
                if (prices[i] < currBuy         //found better chance to buy
                    || prices[i] < currSell)    //should have sold previously
                {
                    if (i > buyDay + 1)
                        res += currSell - currBuy;
                    
                    currBuy = prices[i];
                    currSell = -1;
                    buyDay = i;
                }
                else
                {
                    currSell = prices[i];
                    if (i == len - 1)
                        res += currSell - currBuy;
                }
            }

            return res;
        }
    }
}