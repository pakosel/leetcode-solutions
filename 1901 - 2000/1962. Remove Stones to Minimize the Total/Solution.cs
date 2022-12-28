using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace RemoveStonesToMinimizeTheTotal
{
    public class Solution
    {
        public int MinStoneSum(int[] piles, int k)
        {
            var pq = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
            var res = 0;

            foreach (var p in piles)
            {
                pq.Enqueue(p, p);
                res += p;
            }

            while (k-- > 0)
            {
                var curr = pq.Dequeue();
                res -= curr / 2;
                curr -= curr / 2;

                pq.Enqueue(curr, curr);
            }
            return res;
        }
    }
}