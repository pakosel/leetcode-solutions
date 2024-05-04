using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MinimumFallingPathSumII
{
    public class Solution
    {
        public int MinFallingPathSum(int[][] grid)
        {
            var n = grid.Length;
            int[,] memo = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    memo[i, j] = -1;
            var res = int.MaxValue;
            for (int i = 0; i < n; i++)
                res = Math.Min(res, Memo(0, i));
            return res;

            int Memo(int r, int c)
            {
                if (memo[r, c] != -1)
                    return memo[r, c];
                var res = int.MaxValue;
                if (r != n - 1)
                {
                    for (int i = 0; i < n; i++)
                        if (i != c)
                            res = Math.Min(res, grid[r][c] + Memo(r + 1, i));
                }
                else
                    res = grid[r][c];

                memo[r, c] = res;
                return res;
            }
        }
    }
}