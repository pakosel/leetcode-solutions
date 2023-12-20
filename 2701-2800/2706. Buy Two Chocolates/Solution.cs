using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace BuyTwoChocolates
{
    public class Solution
    {
        public int BuyChoco(int[] prices, int money)
        {
            Array.Sort(prices);
            var min = prices[0] + prices[1];
            if (money >= min)
                return money - min;
            return money;
        }
    }
}