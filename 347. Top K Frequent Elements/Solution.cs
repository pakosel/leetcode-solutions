using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace TopKFrequentElements
{
    public class Solution
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            var dict = new Dictionary<int, int>();
            foreach (var n in nums)
                if (dict.ContainsKey(n))
                    dict[n]++;
                else
                    dict.Add(n, 1);
            var pq = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));

            foreach (var kvp in dict)
                pq.Enqueue(kvp.Key, kvp.Value);
            var res = new int[k];
            for (int i = 0; i < k; i++)
                res[i] = pq.Dequeue();
            return res;
        }
    }
}