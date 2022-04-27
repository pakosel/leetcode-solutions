using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace SmallestStringWithSwaps
{
    public class Solution
    {
        Dictionary<int, HashSet<int>> dict = new();
        HashSet<int> Sorted = new();
        public string SmallestStringWithSwaps(string s, IList<IList<int>> pairs)
        {
            foreach (var p in pairs)
            {
                if (p[0] == p[1])
                    continue;

                if (!dict.ContainsKey(p[0]))
                    dict.Add(p[0], new HashSet<int>());
                if (!dict.ContainsKey(p[1]))
                    dict.Add(p[1], new HashSet<int>());
                
                dict[p[0]].Add(p[1]);
                dict[p[1]].Add(p[0]);
            }
            var res = new StringBuilder(s);
            foreach (var p in dict.Keys)
            {
                if (Sorted.Contains(p))
                    continue;
                var chars = new PriorityQueue<char, char>();
                var indexes = new PriorityQueue<int, int>();

                Dfs(res, p, chars, indexes, new HashSet<int>());
                Process(res, chars, indexes);
            }

            return res.ToString();
        }

        private void Dfs(StringBuilder sb, int start, PriorityQueue<char, char> chars, PriorityQueue<int, int> indexes, HashSet<int> visited)
        {
            if (!dict.ContainsKey(start) || visited.Contains(start))
                return;
            visited.Add(start);
            chars.Enqueue(sb[start], sb[start]);
            indexes.Enqueue(start, start);
            foreach (var p in dict[start])
                Dfs(sb, p, chars, indexes, visited);
        }

        private void Process(StringBuilder res, PriorityQueue<char, char> pq, PriorityQueue<int, int> indexes)
        {
            while (indexes.Count > 0)
            {
                var idx = indexes.Dequeue();
                res[idx] = pq.Dequeue();
                Sorted.Add(idx);
            }
        }
    }
}