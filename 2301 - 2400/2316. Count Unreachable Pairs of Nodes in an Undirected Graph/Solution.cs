using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace CountUnreachablePairsOfNodesInAnUndirectedGraph
{
    public class Solution
    {
        public long CountPairs(int n, int[][] edges)
        {
            var graph = new List<int>[n];
            foreach(var e in edges)
            {
                if(graph[e[0]] == null)
                    graph[e[0]] = new List<int>();
                if(graph[e[1]] == null)
                    graph[e[1]] = new List<int>();
                graph[e[0]].Add(e[1]);
                graph[e[1]].Add(e[0]);
            }
            long all = n;
            long res = 0;
            var visited = new HashSet<int>();
            for(int i=0; i<n && all > 0; i++)
            {
                if(visited.Contains(i))
                    continue;
                var set = new HashSet<int>();
                Dfs(i, set);
                all -= set.Count;
                res += set.Count * all;
                foreach(var v in set)
                    visited.Add(v);
            }
            return res;

            void Dfs(int node, HashSet<int> visited)
            {
                var q = new Queue<int>();
                q.Enqueue(node);
                while(q.Count > 0)
                {
                    var n = q.Dequeue();
                    if(visited.Contains(n))
                        continue;
                    visited.Add(n);
                    if(graph[n] != null)
                        foreach(var e in graph[n])
                            if(!visited.Contains(e) && !q.Contains(e))
                                q.Enqueue(e);
                }
            }
        }
    }
}