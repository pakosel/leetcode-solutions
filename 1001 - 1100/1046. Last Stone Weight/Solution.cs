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
            var pq = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
            foreach (var s in stones)
                pq.Enqueue(s, s);
            while (pq.Count > 1)
            {
                var e1 = pq.Dequeue();
                var e2 = pq.Dequeue();
                if (e1 != e2)
                    pq.Enqueue(e1 - e2, e1 - e2);
            }
            return pq.Count > 0 ? pq.Dequeue() : 0;
        }
    }
}