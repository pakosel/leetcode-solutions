using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ShortestPathInGridWithObstacles
{
    public class Solution
    {
        public int ShortestPath(int[][] grid, int k)
        {
            var w = grid[0].Length;
            var h = grid.Length;
            var visited = Enumerable.Range(0, h).Select(_ => new int[w]).ToArray();
            foreach (var r in visited)
                Array.Fill(r, -1);

            var res = int.MaxValue;
            var q = new Queue<(int r, int c, int k, int steps)>();

            q.Enqueue((0, 0, k, 0));
            var moves = new int[] { -1, 1 };

            while (q.Count > 0)
            {
                var curr = q.Dequeue();

                if (curr.r == h - 1 && curr.c == w - 1)
                    return curr.steps;

                if (visited[curr.r][curr.c] >= curr.k)
                    continue;
                else
                    visited[curr.r][curr.c] = curr.k;

                foreach (int mv in moves)
                {
                    Enqueue(curr.r + mv, curr.c, curr.k, curr.steps);
                    Enqueue(curr.r, curr.c + mv, curr.k, curr.steps);
                }
            }

            return res == int.MaxValue ? -1 : res;

            void Enqueue(int r, int c, int k, int steps)
            {
                if (r >= 0 && r < h && c >= 0 && c < w)
                {
                    var newK = k - grid[r][c];
                    if (newK >= 0 && visited[r][c] < newK)
                        q.Enqueue((r, c, newK, steps + 1));
                }
            }
        }
    }
}