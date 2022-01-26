using System.Collections.Generic;
using System.Linq;
using System;
using Common;

namespace NumberOfIslands
{
    public class Solution
    {
        public int NumIslands(char[][] grid)
        {
            var res = 0;
            for (int r = 0; r < grid.Length; r++)
                for (int c = 0; c < grid[0].Length; c++)
                    if (grid[r][c] == '1')
                    {
                        res++;
                        var q = new Queue<(int r, int c)>();
                        q.Enqueue((r, c));
                        while (q.Count > 0)
                        {
                            var curr = q.Dequeue();
                            if (grid[curr.r][curr.c] != '1')
                                continue;
                            grid[curr.r][curr.c] = 'x';
                            if (curr.r + 1 < grid.Length && grid[curr.r + 1][curr.c] == '1')
                                q.Enqueue((curr.r + 1, curr.c));
                            if (curr.r - 1 >= 0 && grid[curr.r - 1][curr.c] == '1')
                                q.Enqueue((curr.r - 1, curr.c));
                            if (curr.c - 1 >= 0 && grid[curr.r][curr.c - 1] == '1')
                                q.Enqueue((curr.r, curr.c - 1));
                            if (curr.c + 1 < grid[0].Length && grid[curr.r][curr.c + 1] == '1')
                                q.Enqueue((curr.r, curr.c + 1));
                        }
                    }

            return res;
        }
    }
}