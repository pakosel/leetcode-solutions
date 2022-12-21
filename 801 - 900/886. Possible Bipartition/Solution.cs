using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace PossibleBipartition
{
    public class Solution
    {
        public bool PossibleBipartition(int n, int[][] dislikes)
        {
            var nb = Enumerable.Range(0, n + 1).Select(_ => new HashSet<int>()).ToArray();
            foreach (var p in dislikes)
            {
                nb[p[0]].Add(p[1]);
                nb[p[1]].Add(p[0]);
            }
            var col = new int[n + 1];

            for (int i = 1; i <= n; i++)
                if (col[i] == 0 && !Bfs(i))
                    return false;

            return true;

            bool Bfs(int node)
            {
                var q = new Queue<int>();
                col[node] = 1;
                q.Enqueue(node);

                while (q.Count > 0)
                {
                    var curr = q.Dequeue();
                    foreach (var dest in nb[curr])
                        if (col[curr] == col[dest])
                            return false;
                        else if (col[dest] == 0)
                        {
                            col[dest] = (col[curr] == 1 ? 2 : 1);
                            q.Enqueue(dest);
                        }
                }

                return true;
            }
        }
    }
}