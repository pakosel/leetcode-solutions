using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace EliminateMaximumNumberOfMonsters
{
    public class Solution
    {
        public int EliminateMaximum(int[] dist, int[] speed)
        {
            var n = dist.Length;
            var pq = new PriorityQueue<(int d, int s), double>();
            for (int i = 0; i < n; i++)
                pq.Enqueue((dist[i], speed[i]), (double)dist[i] / speed[i]);
            var res = 0;
            while (pq.Count > 0)
            {
                var (d, s) = pq.Dequeue();
                if (d - res * s > 0)
                    res++;
                else
                    break;
            }
            return res;
        }
    }
}