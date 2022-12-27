using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MaximumBagsWithFullCapacityOfRocks
{
    public class Solution
    {
        public int MaximumBags(int[] capacity, int[] rocks, int additionalRocks)
        {
            int len = rocks.Length;
            for (int i = 0; i < len; i++)
                capacity[i] -= rocks[i];
            Array.Sort(capacity);
            var res = 0;
            for (int i = 0; i < len; i++)
                if (additionalRocks >= capacity[res])
                {
                    additionalRocks -= capacity[res];
                    res++;
                }
                else
                    break;
            return res;
        }
    }
}