using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace LargestColorValueInDirectedGraph
{
    public class Solution
    {
        public int LargestPathValue(string colors, int[][] edges)
        {
            var leaves = new HashSet<int>();
            var nodes = new HashSet<int>();
            var graph = new Dictionary<int, List<int>>();
            var n = colors.Length;

            BuildReversedGraph();

            var arr = Enumerable.Range(0, n).Select(_ => new int[26]).ToArray();
            if (leaves.Count == 0)
                return edges.Count() == 0 ? 1 : -1;

            var res = 0;
            foreach (var leaf in leaves)
            {
                if (res == -1) break;
                Dfs(leaf, new int[26], new HashSet<int>());
            }

            return res;

            void Dfs(int node, int[] seenColors, HashSet<int> visited)
            {
                if (visited.Contains(node))
                    res = -1;
                else if (res != -1)
                {
                    visited.Add(node);
                    var col = colors[node];
                    seenColors[col - 'a']++;
                    var anyBetter = false;
                    for (int i = 0; i < 26; i++)
                    {
                        if (seenColors[i] > arr[node][i])
                            anyBetter = true;
                        arr[node][i] = Math.Max(arr[node][i], seenColors[i]);
                        res = Math.Max(res, arr[node][i]);
                    }
                    if (anyBetter && graph.ContainsKey(node))
                        foreach (var dest in graph[node])
                            Dfs(dest, seenColors, visited);
                    visited.Remove(node);
                    seenColors[col - 'a']--;
                }
            }

            void BuildReversedGraph()
            {
                foreach (var e in edges)
                {
                    if (!nodes.Contains(e[1]) && !leaves.Contains(e[1]))
                        leaves.Add(e[1]);
                    if (leaves.Contains(e[0]))
                    {
                        leaves.Remove(e[0]);
                        nodes.Add(e[0]);
                    }
                    if (!graph.ContainsKey(e[1]))
                        graph.Add(e[1], new List<int>());
                    graph[e[1]].Add(e[0]);
                }
            }
        }
    }
}