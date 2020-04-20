using System;
using System.Collections.Generic;
using System.Text;

namespace MaxProfit
{
    public class Solution
    {
        public static int MaxProfitWithKTransactions(int[] prices, int k)
        {
            int len = prices.Length;

            if (len <= 2 || k < 1)
            {
                if (len == 2)
                    return prices[1] - prices[0];
                else
                    return 0;
            }

            List<int> candidates = new List<int>();
            int currBuy = prices[0];
            int currSell = prices[1];
            int buyDay = 0;
            for (int i = 1; i < len; i++)
            {
                if (prices[i] < currBuy         //found better chance to buy
                    || prices[i] < currSell)    //should have sold previously
                {
                    if (i > buyDay + 1)
                        candidates.Add(currSell - currBuy);
                    //if (prices[i] < currBuy)
                    currBuy = prices[i];
                    currSell = -1;
                    buyDay = i;
                }
                else
                {
                    currSell = prices[i];
                    if(i == len - 1)
                        candidates.Add(currSell - currBuy);
                }
            }

            //Console.Out.WriteLine(string.Join(',', candidates));
            
            //order candidates
            candidates.Sort();

            //select k highest
            var max = 0;
            var idx = candidates.Count - 1;
            while (idx >= 0 && k > 0)
            {
                max += candidates[idx];
                idx--;
                k--;
            }

            return max;
        }

    }
}