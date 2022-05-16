using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ShortestPathInBinaryMatrix
{
    public class Solution
    {
        public int ShortestPathBinaryMatrix(int[][] grid)
        {
            int n = grid.Length;
            if (grid[n - 1][n - 1] != 0)
                return -1;

            var queue = new Queue<(int x, int y, int len)>();

            queue.Enqueue((0, 0, 1));
            while (queue.Count > 0)
            {
                var q = queue.Dequeue();
                if (q.x < 0 || q.x >= n || q.y < 0 || q.y >= n)
                    continue;
                
                var val = grid[q.x][q.y];
                if (val == 1)
                    continue;
                if (val == 0 || val > q.len)
                {
                    grid[q.x][q.y] = q.len;
                    queue.Enqueue((q.x, q.y + 1, q.len + 1));
                    queue.Enqueue((q.x, q.y - 1, q.len + 1));
                    queue.Enqueue((q.x + 1, q.y, q.len + 1));
                    queue.Enqueue((q.x - 1, q.y, q.len + 1));
                    queue.Enqueue((q.x + 1, q.y + 1, q.len + 1));
                    queue.Enqueue((q.x + 1, q.y - 1, q.len + 1));
                    queue.Enqueue((q.x - 1, q.y + 1, q.len + 1));
                    queue.Enqueue((q.x - 1, q.y - 1, q.len + 1));
                }
            }

            var min = grid[n - 1][n - 1];
            return min != 0 ? min : -1;
        }
    }
}