using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ShortestPathWithAlternatingColors
{
    public class Solution
    {
        public int[] ShortestAlternatingPaths(int n, int[][] redEdges, int[][] blueEdges)
        {
            var red = DictEdges(redEdges);
            var blue = DictEdges(blueEdges);

            var fromRed = new int[n];
            var fromBlue = new int[n];
            Array.Fill(fromRed, int.MaxValue);
            Array.Fill(fromBlue, int.MaxValue);

            var q = new Queue<(int node, bool fromRed, int path)>();
            q.Enqueue((0, true, 0));
            q.Enqueue((0, false, 0));

            while (q.Count > 0)
            {
                var curr = q.Dequeue();
                var arr = curr.fromRed ? fromRed : fromBlue;
                if (arr[curr.node] <= curr.path)
                    continue;
                arr[curr.node] = curr.path;
                curr.path++;

                var nextColl = curr.fromRed ? blue : red;
                if (!nextColl.ContainsKey(curr.node))
                    continue;
                foreach (var dest in nextColl[curr.node])
                    if ((nextColl == red && fromRed[dest] > curr.path) || (nextColl == blue && fromBlue[dest] > curr.path))
                        q.Enqueue((dest, !curr.fromRed, curr.path));
            }

            var res = new int[n];
            for (int i = 0; i < n; i++)
            {
                res[i] = Math.Min(fromRed[i], fromBlue[i]);
                if (res[i] == int.MaxValue)
                    res[i] = -1;
            }
            return res;

            Dictionary<int, HashSet<int>> DictEdges(int[][] edges)
            {
                var dict = new Dictionary<int, HashSet<int>>();
                foreach (var e in edges)
                    if (dict.ContainsKey(e[0]))
                        dict[e[0]].Add(e[1]);
                    else
                        dict.Add(e[0], new HashSet<int>(n) { e[1] });
                return dict;
            }
        }
    }
}