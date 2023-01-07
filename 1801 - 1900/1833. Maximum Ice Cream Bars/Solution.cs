using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MaximumIceCreamBars
{
    public class Solution
    {
        public int MaxIceCream(int[] costs, int coins)
        {
            Array.Sort(costs);
            var idx = 0;
            var res = 0;
            while (coins > 0 && idx < costs.Length)
                if (costs[idx] <= coins)
                {
                    coins -= costs[idx++];
                    res++;
                }
                else
                    break;
            return res;
        }
    }
}