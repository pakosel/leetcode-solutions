using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace LargestLocalValuesInMatrix
{
    public class Solution
    {
        public int[][] LargestLocal(int[][] grid)
        {
            int rows = grid.Length, cols = grid[0].Length;
            var res = new int[rows - 2][];
            for (int r = 0; r < rows - 2; r++)
            {
                res[r] = new int[cols - 2];
                for (int c = 0; c < cols - 2; c++)
                    res[r][c] = Max(r, c);
            }
            return res;

            int Max(int r, int c)
            {
                var res = 0;
                for (int i = r; i < r + 3; i++)
                    for (int j = c; j < c + 3; j++)
                        res = Math.Max(res, grid[i][j]);
                return res;
            }
        }
    }
}