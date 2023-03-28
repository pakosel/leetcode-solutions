using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace LongestCycleInGraph
{
    public class Solution
    {
        public int LongestCycle(int[] edges)
        {
            var visited = new HashSet<int>();
            var res = -1;

            for (int i = 0; i < edges.Length; i++)
                Visit(i, 0, new Dictionary<int, int>());

            return res;

            void Visit(int node, int path, Dictionary<int, int> dictVisited)
            {
                if (node == -1)
                    return;

                if (dictVisited.ContainsKey(node))
                    res = Math.Max(res, path - dictVisited[node]);
                else if (!visited.Contains(node))
                {
                    dictVisited.Add(node, path);
                    visited.Add(node);
                    Visit(edges[node], path + 1, dictVisited);
                }
            }
        }
    }
}