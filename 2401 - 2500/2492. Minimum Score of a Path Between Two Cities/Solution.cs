using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MinimumScoreOfPathBetweenTwoCities
{
    public class Solution
    {
        public int MinScore(int n, int[][] roads)
        {
            var graph = BuildGraph(roads);
            var visitedRoads = new HashSet<(int s, int e)>();
            var minDist = int.MaxValue;
            Dfs(1);

            return minDist;

            void Dfs(int node)
            {
                foreach (var tgt in graph[node])
                {
                    var road = Normalize((node, tgt.node));
                    if (visitedRoads.Contains(road))
                        continue;
                    visitedRoads.Add(road);
                    minDist = Math.Min(minDist, tgt.dist);
                    Dfs(tgt.node);
                }
            }

            (int s, int e) Normalize((int s, int e) edge) => edge.s <= edge.e ? edge : (edge.e, edge.s);

            Dictionary<int, List<(int node, int dist)>> BuildGraph(int[][] roads)
            {
                var res = new Dictionary<int, List<(int, int)>>();
                foreach (var r in roads)
                {
                    if (!res.ContainsKey(r[0]))
                        res.Add(r[0], new List<(int, int)>());
                    if (!res.ContainsKey(r[1]))
                        res.Add(r[1], new List<(int, int)>());
                    res[r[0]].Add((r[1], r[2]));
                    res[r[1]].Add((r[0], r[2]));
                }
                return res;
            }
        }
    }
}