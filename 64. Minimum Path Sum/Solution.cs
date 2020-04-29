using System.Collections.Generic;
using System.Linq;
using System;

namespace MinimumPathSum
{
    public class Solution
    {
        public int MinPathSum(int[][] grid)
        {
            var inf = int.MaxValue / 2;
            var len = grid.Length;
            int[][] sums = new int[len][];
            for (int i = 0; i < len; i++)
            {
                var len1 = grid[i].Length;
                sums[i] = new int[len1];
                for (int j = 0; j < len1; j++)
                {
                    if (i == 0 && j == 0)
                        sums[i][j] = grid[i][j];
                    else
                    {
                        var upper = i > 0 && j < sums[i - 1].Length ? sums[i - 1][j] : inf;
                        var left = j > 0 ? sums[i][j - 1] : inf;
                        sums[i][j] = Math.Min(upper + grid[i][j], left + grid[i][j]);
                    }
                }
            }
            var lastLen = grid[len - 1].Length;
            return sums[len - 1][lastLen - 1];
        }
    }
}