using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace NumberOfOperationsToMakeNetworkConnected
{
    public class Solution
    {
        public int MakeConnected(int n, int[][] connections)
        {
            var conns = connections.Length;
            if (conns < n - 1)
                return -1;

            var dict = new Dictionary<int, HashSet<int>>();
            for (int i = 0; i < n; i++)
                dict.Add(i, new HashSet<int>());

            foreach (var p in connections)
            {
                dict[p[0]].Add(p[1]);
                dict[p[1]].Add(p[0]);
            }

            var visited = new HashSet<int>();
            var clusters = 0;
            var q = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                if (!visited.Contains(i))
                {
                    q.Enqueue(i);
                    clusters++;

                    while (q.Count > 0)
                    {
                        var e = q.Dequeue();
                        if (visited.Contains(e))
                            continue;
                        visited.Add(e);
                        foreach (var t in dict[e])
                            if (!visited.Contains(t) && !q.Contains(t))
                                q.Enqueue(t);
                    }
                }
            }
            return clusters - 1;
        }
    }
}