using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace CountNegativeNumbersInSortedMatrix
{
    public class Solution
    {
        public int CountNegatives(int[][] grid)
        {
            var rows = grid.Length;
            var cols = grid[0].Length;
            var res = 0;
            for (int r = rows - 1; r >= 0 && grid[r][cols - 1] < 0; r--)
                for (int c = cols - 1; c >= 0 && grid[r][c] < 0; c--)
                    res++;
            return res;
        }
    }
}