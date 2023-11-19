using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace ReductionOperationsToMakeTheArrayElementsEqual
{
    public class Solution
    {
        public int ReductionOperations(int[] nums)
        {
            var counts = new Dictionary<int, int>();
            var pq = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
            var min = int.MaxValue;
            foreach (var n in nums)
            {
                min = Math.Min(min, n);
                if (counts.ContainsKey(n))
                    counts[n]++;
                else
                {
                    counts[n] = 1;
                    pq.Enqueue(n, n);
                }
            }
            var res = 0;
            while (pq.Count > 1)
                res += (pq.Count - 1) * counts[pq.Dequeue()];
            return res;
        }
    }
}