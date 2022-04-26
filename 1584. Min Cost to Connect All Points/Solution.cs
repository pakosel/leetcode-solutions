using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MinCostToConnectAllPoints
{
    public class Solution
    {
        public int MinCostConnectPoints(int[][] points)
        {
            var pq = new PriorityQueue<(int i, int j), int>();
            for (int i = 0; i < points.Length; i++)
                for (int j = i + 1; j < points.Length; j++)
                    pq.Enqueue((i, j), Dist(points, i, j));

            var ptGroup = new int[points.Length];
            Array.Fill(ptGroup, -1);
            var groups = new Dictionary<int, HashSet<int>>();

            var res = 0;
            while (pq.Count > 0)
            {
                var curr = pq.Dequeue();
                if (ptGroup[curr.i] == ptGroup[curr.j] && ptGroup[curr.i] != -1)
                    continue;
                
                res += Dist(points, curr.i, curr.j);;

                var grpId = groups.Count;
                if (ptGroup[curr.i] == -1 && ptGroup[curr.j] == -1)
                {
                    groups.Add(grpId, new HashSet<int>());
                    groups[grpId].Add(curr.i);
                    groups[grpId].Add(curr.j);
                }
                else if (ptGroup[curr.i] != -1)
                {
                    grpId = ptGroup[curr.i];
                    JoinGroups(groups, ptGroup, grpId, ptGroup[curr.j]);
                    groups[grpId].Add(curr.j);
                }
                else
                {
                    grpId = ptGroup[curr.j];
                    JoinGroups(groups, ptGroup, grpId, ptGroup[curr.i]);
                    groups[grpId].Add(curr.i);
                }
                ptGroup[curr.i] = grpId;
                ptGroup[curr.j] = grpId;

                if (groups[grpId].Count == points.Length)
                    break;
            }
            return res;
        }

        private int Dist(int[][] points, int i, int j) => Math.Abs(points[i][0] - points[j][0]) + Math.Abs(points[i][1] - points[j][1]);

        private void JoinGroups(Dictionary<int, HashSet<int>> groups, int[] ptGroup, int tgt, int src)
        {
            if (!groups.ContainsKey(src))
                return;
            foreach (var e in groups[src])
            {
                groups[tgt].Add(e);
                ptGroup[e] = tgt;
            }
            // groups.Remove(src);
        }
    }
}