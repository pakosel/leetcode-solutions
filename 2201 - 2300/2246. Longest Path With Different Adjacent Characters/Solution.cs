using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace LongestPathWithDifferentAdjacentCharacters
{
    public class Solution
    {
        public int LongestPath(int[] parent, string s)
        {
            var n = parent.Length;
            var graph = new List<int>[n];
            for (int i = 0; i < n; i++)
            {
                var p = parent[i];
                if (p < 0)
                    continue;

                if (graph[p] == null)
                    graph[p] = new List<int>();
                graph[p].Add(i);
            }
            
            var res = 1;
            dfs(0);

            return res;

            int dfs(int currentNode)
            {
                if (graph[currentNode] == null)
                    return 1;

                var long1 = 0;
                var long2 = 0;
                foreach (var child in graph[currentNode])
                {
                    int longCurr = dfs(child);
                    if (s[currentNode] == s[child])
                        continue;

                    if (longCurr > long1)
                        (long2, long1) = (long1, longCurr);
                    else if (longCurr > long2)
                        long2 = longCurr;
                }

                res = Math.Max(res, long1 + long2 + 1);

                return long1 + 1;
            }
        }
    }
}