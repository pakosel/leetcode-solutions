using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace OnlineStockSpan
{
    public class StockSpanner
    {
        List<(int price, int cnt)> list;
        public StockSpanner()
        {
            list = new List<(int price, int cnt)>();
        }

        public int Next(int price)
        {
            var pos = list.Count - 1;
            var res = 1;
            while (pos >= 0 && list[pos].price <= price)
            {
                res += list[pos].cnt;
                pos -= list[pos].cnt;
            }
            list.Add((price, res));

            return res;
        }
    }
}