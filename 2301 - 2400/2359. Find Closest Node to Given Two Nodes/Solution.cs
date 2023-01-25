using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace FindClosestNodeToGivenTwoNodes
{
    public class Solution
    {
        const int MAX = 100001;
        public int ClosestMeetingNode(int[] edges, int node1, int node2)
        {
            var visited1 = new Dictionary<int, int>();
            var visited2 = new Dictionary<int, int>();
            var steps = 0;
            while (node1 != -1)
            {
                if (visited1.ContainsKey(node1))
                    break;
                visited1.Add(node1, steps++);
                node1 = edges[node1];
            }

            (int node, int steps) res = (MAX, MAX);
            steps = 0;
            while (node2 != -1)
            {
                if (visited2.ContainsKey(node2))
                    break;
                if (visited1.ContainsKey(node2))
                    //maximum between the distance from node1 to that node, and from node2 to that node is minimized
                    if (Math.Max(steps, visited1[node2]) < res.steps ||
                       (Math.Max(steps, visited1[node2]) == res.steps && node2 < res.node))
                        res = (node2, Math.Max(visited1[node2], steps));

                visited2.Add(node2, steps++);
                node2 = edges[node2];
            }
            return res == (MAX, MAX) ? -1 : res.node;
        }
    }
}