using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace RestoreTheArrayFromAdjacentPairs
{
    public class Solution
    {
        public int[] RestoreArray(int[][] adjacentPairs)
        {
            var graph = BuildGraph();
            var res = new List<int>();
            var visited = new HashSet<int>();
            var leaf = graph.First(kvp => kvp.Value.Count == 1);

            Dfs(leaf.Key);

            return res.ToArray();

            void Dfs(int node)
            {
                if (visited.Contains(node))
                    return;
                visited.Add(node);
                res.Add(node);
                foreach (var next in graph[node])
                    Dfs(next);
            }

            Dictionary<int, List<int>> BuildGraph()
            {
                var res = new Dictionary<int, List<int>>();
                foreach (var p in adjacentPairs)
                {
                    if (!res.ContainsKey(p[0]))
                        res.Add(p[0], new List<int>());
                    if (!res.ContainsKey(p[1]))
                        res.Add(p[1], new List<int>());
                    res[p[0]].Add(p[1]);
                    res[p[1]].Add(p[0]);
                }
                return res;
            }

        }
    }
}