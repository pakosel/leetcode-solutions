using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace NumberOfProvinces
{
    public class Solution
    {
        public int FindCircleNum(int[][] isConnected)
        {
            var n = isConnected.Length;
            var graph = new List<int>[n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (i != j && isConnected[i][j] == 1)
                    {
                        if (graph[i] == null)
                            graph[i] = new List<int>();
                        graph[i].Add(j);
                    }

            var visited = new HashSet<int>();
            var res = 0;
            for (int i = 0; i < n; i++)
                if (!visited.Contains(i))
                {
                    Dfs(i);
                    res++;
                }
            return res;

            void Dfs(int node)
            {
                if (visited.Contains(node))
                    return;
                visited.Add(node);
                if (graph[node] != null)
                    foreach (var dest in graph[node])
                        Dfs(dest);
            }

        }
    }
}