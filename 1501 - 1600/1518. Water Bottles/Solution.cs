using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace WaterBottles
{
    public class Solution
    {
        public int NumWaterBottles(int numBottles, int numExchange)
        {
            int res = 0, mod = 0;
            while (numBottles > 0)
            {
                res += numBottles;
                (numBottles, mod) = ((numBottles + mod) / numExchange, (numBottles + mod) % numExchange);
            }
            return res;
        }
    }
}