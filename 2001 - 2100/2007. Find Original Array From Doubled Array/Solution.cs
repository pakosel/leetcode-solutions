using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace FindOriginalArrayFromDoubledArray
{
    public class Solution
    {
        public int[] FindOriginalArray(int[] changed)
        {
            if (changed.Length % 2 != 0)
                return new int[0];
            var dict = new Dictionary<int, int>(changed.Length);
            var pq = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
            var res = new List<int>(changed.Length / 2);

            foreach (var el in changed)
            {
                if (dict.ContainsKey(el))
                    dict[el]++;
                else
                    dict.Add(el, 1);
                pq.Enqueue(el, el);
            }

            while (res.Count < changed.Length / 2)
            {
                var curr = pq.Dequeue();
                if (dict[curr] == 0)
                    continue;
                if (curr % 2 != 0 || !dict.ContainsKey(curr / 2) || dict[curr / 2] == 0)
                    return new int[0];
                dict[curr]--;
                dict[curr / 2]--;
                res.Add(curr / 2);
            }
            return res.ToArray();
        }
    }
}