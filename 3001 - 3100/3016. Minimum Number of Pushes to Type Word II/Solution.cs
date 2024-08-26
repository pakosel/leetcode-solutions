using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MinimumNumberOfPushesToTypeWordII
{
    public class Solution
    {
        public int MinimumPushes(string word)
        {
            var letters = new int[26];
            foreach (var e in word)
                letters[e - 'a']++;
            var pq = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
            foreach (var e in letters)
                if (e > 0)
                    pq.Enqueue(e, e);
            int keys = 8, pushes = 1, res = 0;

            while (pq.Count > 0)
            {
                res += pq.Dequeue() * pushes;
                if (--keys == 0)
                {
                    keys = 8;
                    pushes++;
                }
            }
            return res;
        }
    }
}