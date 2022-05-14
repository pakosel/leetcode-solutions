using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace NetworkDelayTime
{
    public class Solution
    {
        public int NetworkDelayTime(int[][] times, int n, int k)
        {
            // var dict = times.GroupBy(t => t[0]).ToDictionary(t => t.Key, t => t.Select(v => (dest: v[1], time: v[2])));
            //below is ~2x faster
            var dict = new Dictionary<int, List<(int dest, int time)>>();
            foreach (var t in times)
            {
                if (!dict.ContainsKey(t[0]))
                    dict.Add(t[0], new List<(int, int)>());
                dict[t[0]].Add((t[1], t[2]));
            }

            var visited = new Dictionary<int, int>();
            var queue = new Queue<(int node, int time)>();
            queue.Enqueue((k, 0));
            while (queue.Count > 0)
            {
                var curr = queue.Dequeue();
                if (visited.ContainsKey(curr.node))
                    if (visited[curr.node] <= curr.time)
                        continue;
                    else
                        visited[curr.node] = curr.time;
                else
                    visited.Add(curr.node, curr.time);

                if (dict.ContainsKey(curr.node))
                    foreach (var tgt in dict[curr.node])
                        queue.Enqueue((tgt.dest, tgt.time + curr.time));
            }

            if (visited.Count < n)
                return -1;
            return visited.Values.Max();
        }
    }
}