using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MaxAreaOfIsland
{
    public class Solution
    {
        public int MaxAreaOfIsland(int[][] grid)
        {
            var max = 0;
            for (int i = 0; i < grid.Length; i++)
                for (int j = 0; j < grid[0].Length; j++)
                    if (grid[i][j] == 1)
                        max = Math.Max(max, Dfs(i, j));
            return max;

            int Dfs(int i, int j)
            {
                var q = new Queue<(int y, int x)>();
                q.Enqueue((i, j));
                var res = 0;
                while (q.Count > 0)
                {
                    var curr = q.Dequeue();
                    if (grid[curr.y][curr.x] != 1)
                        continue;
                    grid[curr.y][curr.x] = 0;
                    res++;
                    if (curr.y - 1 >= 0 && grid[curr.y - 1][curr.x] == 1)
                        q.Enqueue((curr.y - 1, curr.x));
                    if (curr.y + 1 < grid.Length && grid[curr.y + 1][curr.x] == 1)
                        q.Enqueue((curr.y + 1, curr.x));
                    if (curr.x - 1 >= 0 && grid[curr.y][curr.x - 1] == 1)
                        q.Enqueue((curr.y, curr.x - 1));
                    if (curr.x + 1 < grid[0].Length && grid[curr.y][curr.x + 1] == 1)
                        q.Enqueue((curr.y, curr.x + 1));
                }
                return res;
            }
        }
    }
}