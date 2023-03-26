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
            var dictVisited = new Dictionary<int, int>();
            var res = -1;

            for (int i = 0; i < edges.Length; i++)
            {
                dictVisited.Clear();
                Visit(i, 0);
            }

            return res;

            void Visit(int node, int path)
            {
                if (node == -1)
                    return;

                if (dictVisited.ContainsKey(node))
                    res = Math.Max(res, path - dictVisited[node]);
                else if (!visited.Contains(node))
                {
                    dictVisited.Add(node, path);
                    visited.Add(node);
                    Visit(edges[node], path + 1);
                }
            }
        }
    }
}