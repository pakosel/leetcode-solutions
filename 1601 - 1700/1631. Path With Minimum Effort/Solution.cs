using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace PathWithMinimumEffort
{
    public class Solution
    {
        public int MinimumEffortPath(int[][] heights)
        {
            var rows = heights.Length;
            var cols = heights[0].Length;
            var arr = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                arr[i] = new int[cols];
                Array.Fill(arr[i], int.MaxValue);
            }

            var pq = new PriorityQueue<(int r, int c, int max), int>();
            pq.Enqueue((0, 0, 0), 0);

            while (pq.Count > 0)
            {
                var curr = pq.Dequeue();
                if (curr.r == rows - 1 && curr.c == cols - 1)
                    return curr.max;
                arr[curr.r][curr.c] = curr.max;

                if (curr.r > 0)
                {
                    var path = Math.Max(curr.max, Math.Abs(heights[curr.r][curr.c] - heights[curr.r - 1][curr.c]));
                    if (arr[curr.r - 1][curr.c] > path)
                        pq.Enqueue((curr.r - 1, curr.c, path), path);
                }
                if (curr.r < rows - 1)
                {
                    var path = Math.Max(curr.max, Math.Abs(heights[curr.r][curr.c] - heights[curr.r + 1][curr.c]));
                    if (arr[curr.r + 1][curr.c] > path)
                        pq.Enqueue((curr.r + 1, curr.c, path), path);
                }
                if (curr.c > 0)
                {
                    var path = Math.Max(curr.max, Math.Abs(heights[curr.r][curr.c] - heights[curr.r][curr.c - 1]));
                    if (arr[curr.r][curr.c - 1] > path)
                        pq.Enqueue((curr.r, curr.c - 1, path), path);
                }
                if (curr.c < cols - 1)
                {
                    var path = Math.Max(curr.max, Math.Abs(heights[curr.r][curr.c] - heights[curr.r][curr.c + 1]));
                    if (arr[curr.r][curr.c + 1] > path)
                        pq.Enqueue((curr.r, curr.c + 1, path), path);
                }
            }

            return arr[rows - 1][cols - 1];
        }
    }
}