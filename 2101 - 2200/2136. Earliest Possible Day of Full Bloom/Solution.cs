using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace EarliestPossibleDayOfFullBloom
{
    public class Solution
    {
        public int EarliestFullBloom(int[] plantTime, int[] growTime)
        {
            var len = plantTime.Length;
            var arr = Enumerable.Range(0, len).ToArray();

            //order by growTime DESC then by plantTime DESC
            Array.Sort(arr, (i, j) => growTime[j] == growTime[i] ? plantTime[j].CompareTo(plantTime[i]) : growTime[j].CompareTo(growTime[i]));

            var res = 0;
            var plant = 0;
            foreach(var idx in arr)
            {
                plant += plantTime[idx];
                res = Math.Max(res, plant + growTime[idx]);
            }

            return res;
        }
    }
}