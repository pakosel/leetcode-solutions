using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace NumberOfNodesInTheSubTreeWithTheSameLabel
{
    public class Solution
    {
        public int[] CountSubTrees(int n, int[][] edges, string labels)
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

            var res = new int[n];

            Visit(0);

            return res;

            int[] Visit(int node)
            {
                res[node] = -1;
                var ans = new int[26];
                if (graph.ContainsKey(node))
                    foreach (var n in graph[node])
                    {
                        if (res[n] != 0)
                            continue;
                        var vis = Visit(n);
                        for (int i = 0; i < 26; i++)
                            ans[i] += vis[i];
                    }
                var lab = labels[node];
                ans[lab - 'a']++;
                res[node] = ans[lab - 'a'];

                return ans;
            }
        }
    }
}