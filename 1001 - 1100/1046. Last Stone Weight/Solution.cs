using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace LastStoneWeight
{
    public class Solution
    {
        public int LastStoneWeight(int[] stones)
        {
            var pq = new PriorityQueue<int, int>();
            foreach (var s in stones)
                pq.Enqueue(s, -s);
            while (pq.Count > 1)
            {
                var e1 = pq.Dequeue();
                var e2 = pq.Dequeue();
                var crash = e1 - e2;
                if (crash != 0)
                    pq.Enqueue(crash, -crash);
            }
            return pq.Count > 0 ? pq.Dequeue() : 0;
        }
    }
}