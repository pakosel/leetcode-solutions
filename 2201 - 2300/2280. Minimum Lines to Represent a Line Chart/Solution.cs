using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MinimumLinesToRepresentLineChart
{
    public class Solution
    {
        public int MinimumLines(int[][] stockPrices)
        {
            if (stockPrices.Length < 2)
                return 0;
            Array.Sort(stockPrices, (p1, p2) => p1[0].CompareTo(p2[0]));
            var res = 1;

            decimal prevX = stockPrices[1][0] - stockPrices[0][0];
            decimal prevY = stockPrices[1][1] - stockPrices[0][1];
            for (int i = 2; i < stockPrices.Length; i++)
            {
                decimal currX = stockPrices[i][0] - stockPrices[i - 1][0];
                decimal currY = stockPrices[i][1] - stockPrices[i - 1][1];
                if (currY == 0 && prevY == 0)
                    continue;
                if (currY == 0 || prevY == 0 || currX / currY != prevX / prevY)
                {
                    res++;
                    prevX = currX;
                    prevY = currY;
                }
            }
            return res;
        }
    }
}