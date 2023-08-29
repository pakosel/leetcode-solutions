using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MinimumPenaltyForShop
{
    public class Solution
    {
        public int BestClosingTime(string customers)
        {
            var n = customers.Length;
            var closePen = new int[n + 1];
            var openPen = new int[n + 1];

            for (int i = 0; i < n; i++)
                openPen[i + 1] = openPen[i] + (customers[i] == 'N' ? 1 : 0);
            for (int i = n - 1; i >= 0; i--)
                closePen[i] = closePen[i + 1] + (customers[i] == 'Y' ? 1 : 0);


            (int val, int idx) res = (closePen[0], 0);

            for (int i = 0; i <= n; i++)
                if (openPen[i] + closePen[i] < res.val)
                    res = (openPen[i] + closePen[i], i);

            return res.idx;
        }
    }
}