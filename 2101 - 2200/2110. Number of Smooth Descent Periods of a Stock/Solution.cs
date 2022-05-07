using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace NumberOfSmoothDescentPeriodsOfStock
{
    public class Solution
    {
        public long GetDescentPeriods(int[] prices)
        {
            var res = 1L;
            var isSmooth = 0L;
            for (int i = 1; i < prices.Length; i++, res++)
                if (prices[i - 1] - prices[i] == 1)
                {
                    isSmooth++;
                    res += isSmooth;
                }
                else
                    isSmooth = 0;
            return res;
        }
    }
}