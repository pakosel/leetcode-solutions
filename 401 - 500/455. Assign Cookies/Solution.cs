using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace AssignCookies
{
    public class Solution
    {
        public int FindContentChildren(int[] g, int[] s)
        {
            Array.Sort(g, (x, y) => y.CompareTo(x));
            var pq = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
            foreach (var c in s)
                pq.Enqueue(c, c);
            var res = 0;
            foreach (var e in g)
            {
                if (pq.Count == 0)
                    break;
                if (e <= pq.Peek())
                {
                    res++;
                    pq.Dequeue();
                }
            }
            return res;
        }
    }
}