using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MinimumAmountOfTimeToCollectGarbage
{
    public class Solution
    {
        public int GarbageCollection(string[] garbage, int[] travel)
        {
            var n = garbage.Length;
            var trucks = new char[] { 'G', 'M', 'P' };
            var lastHouse = new int[3] { -1, -1, -1 };
            for (int i = 0; i < n; i++)
                for (int j = 0; j < trucks.Length; j++)
                    if (garbage[i].Contains(trucks[j]))
                        lastHouse[j] = i;
            var res = 0;
            for (int j = 0; j < trucks.Length; j++)
                for (int i = 0; i < n; i++)
                {
                    if (i > lastHouse[j])
                        continue;
                    res += (i > 0 ? travel[i - 1] : 0);
                    res += garbage[i].Count(g => g == trucks[j]);
                }
            return res;
        }
    }
}