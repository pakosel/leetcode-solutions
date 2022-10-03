using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MinimumTimeToMakeRopeColorful
{
    public class Solution
    {
        public int MinCost(string colors, int[] neededTime)
        {
            var res = 0;
            var pq = new PriorityQueue<int, int>();
            var prev = '-';

            for (int i = 0; i < colors.Length; i++)
            {
                if (colors[i] != prev)
                {
                    Bang();
                    prev = colors[i];
                }
                pq.Enqueue(neededTime[i], neededTime[i]);
            }
            Bang();

            return res;

            void Bang()
            {
                while (pq.Count > 1)
                    res += pq.Dequeue();
                pq.Clear();
            }
        }
    }
}