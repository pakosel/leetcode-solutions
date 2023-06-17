using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace EqualRowAndColumnPairs
{
    public class Solution
    {
        public int EqualPairs(int[][] grid)
        {
            var n = grid.Length;
            var res = 0;
            for (int r = 0; r < n; r++)
                for (int c = 0; c < n; c++)
                    res += AreEqual(r, c);
            return res;

            int AreEqual(int row, int col)
            {
                for (int i = 0; i < n; i++)
                    if (grid[row][i] != grid[i][col])
                        return 0;
                return 1;
            }
        }
    }
}