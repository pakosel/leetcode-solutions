using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace ReorderRoutesToMakeAllPathsLeadToTheCityZero
{
    public class Solution
    {
        public int MinReorder(int n, int[][] connections)
        {
            Dictionary<int, HashSet<int>> outgoing = new();
            Dictionary<int, HashSet<int>> incoming = new();
            BuildGraph();
            var visited = new HashSet<int>();
            var res = 0;

            Dfs(0);

            return res;

            void Dfs(int node)
            {
                if (visited.Contains(node))
                    return;
                visited.Add(node);

                if (incoming.ContainsKey(node))
                    foreach (var inc in incoming[node])
                        if (!visited.Contains(inc))
                            Dfs(inc);

                if (outgoing.ContainsKey(node))
                    foreach (var outg in outgoing[node])
                        if (!visited.Contains(outg))
                        {
                            res++;
                            Dfs(outg);
                        }
            }

            void BuildGraph()
            {
                foreach (var conn in connections)
                {
                    if (!outgoing.ContainsKey(conn[0]))
                        outgoing.Add(conn[0], new HashSet<int>());
                    if (!incoming.ContainsKey(conn[1]))
                        incoming.Add(conn[1], new HashSet<int>());
                    outgoing[conn[0]].Add(conn[1]);
                    incoming[conn[1]].Add(conn[0]);
                }
            }
        }
    }
}