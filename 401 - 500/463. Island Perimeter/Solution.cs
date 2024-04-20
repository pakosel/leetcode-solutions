using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace IslandPerimeter
{
    public class Solution
    {
        public int IslandPerimeter(int[][] grid)
        {
            int rows = grid.Length, cols = grid[0].Length;
            var res = 0;
            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols; c++)
                    res += Calc(r, c);
            return res;

            int Calc(int r, int c)
            {
                var res = 0;
                if (grid[r][c] == 0)
                    return res;
                if (r - 1 < 0 || grid[r - 1][c] == 0)
                    res++;
                if (r + 1 == rows || grid[r + 1][c] == 0)
                    res++;
                if (c - 1 < 0 || grid[r][c - 1] == 0)
                    res++;
                if (c + 1 == cols || grid[r][c + 1] == 0)
                    res++;
                return res;
            }
        }
    }

}