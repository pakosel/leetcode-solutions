using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace DetonateTheMaximumBombs
{
    public class Solution
    {
        public int MaximumDetonation(int[][] bombs)
        {
            var len = bombs.Length;
            var graph = BuildGraph();
            var res = 0;

            for (int i = 0; i < len; i++)
            {
                var set = new HashSet<int>();
                Dfs(i, set);
                res = Math.Max(res, set.Count);
            }
            return res;

            void Dfs(int idx, HashSet<int> visited)
            {
                if (visited.Contains(idx))
                    return;
                visited.Add(idx);
                foreach (var dest in graph[idx])
                    Dfs(dest, visited);
            }

            IList<int>[] BuildGraph()
            {
                var res = new List<int>[len];
                for (int i = 0; i < len; i++)
                {
                    res[i] = new List<int>();
                    for (int j = 0; j < len; j++)
                        if (IsInRange(i, j))
                            res[i].Add(j);
                }
                return res;
            }

            bool IsInRange(int i, int j) =>
                (i != j && Math.Sqrt(Math.Pow(bombs[i][0] - bombs[j][0], 2) +
                                       Math.Pow(bombs[i][1] - bombs[j][1], 2)) <= bombs[i][2]);
        }
    }
}