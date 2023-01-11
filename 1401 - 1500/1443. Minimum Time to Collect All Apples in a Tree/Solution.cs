using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MinimumTimeToCollectAllApplesInTree
{
    public class Solution
    {
        public int MinTime(int n, int[][] edges, IList<bool> hasApple)
        {
            var graph = new Dictionary<int, IList<int>>();
            foreach (var e in edges)
            {
                if (!graph.ContainsKey(e[0]))
                    graph.Add(e[0], new List<int>());
                if (!graph.ContainsKey(e[1]))
                    graph.Add(e[1], new List<int>());
                graph[e[0]].Add(e[1]);
                graph[e[1]].Add(e[0]);
            }

            return Visit(0, new HashSet<int>()) ?? 0;

            int? Visit(int node, HashSet<int> visited)
            {
                visited.Add(node);
                var res = 0;

                if (graph.ContainsKey(node))
                    foreach (var v in graph[node])
                        if (!visited.Contains(v))
                            res += (2 + (Visit(v, visited) ?? -2));

                if(res == 0 && !hasApple[node])
                    return null;
                return res;
            }
        }
    }
}