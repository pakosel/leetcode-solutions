using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace OnlineStockSpan
{
    public class StockSpanner
    {
        int count;
        List<(int, int)> prices;

        public StockSpanner()
        {
            count = 0;
            prices = new List<(int, int)>();
        }

        public int Next(int price)
        {
            int i = count;
            int val = 1;
            while (i > 0)
                if (prices[i - 1].Item1 <= price)
                {
                    val += prices[i - 1].Item2;
                    i -= prices[i - 1].Item2;
                }
                else
                    break;
            prices.Add((price, val));
            count++;
            return val;
        }
    }
}