using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace PathWithMaximumGold
{
    public class Solution
    {
        public int GetMaximumGold(int[][] grid)
        {
            var rows = grid.Length;
            var cols = grid[0].Length;
            var res = 0;
            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols; c++)
                    res = Math.Max(res, Dfs(r, c));
            return res;

            int Dfs(int r, int c)
            {
                var gold = grid[r][c];
                if (gold == 0)
                    return 0;
                grid[r][c] = 0;
                var res = 0;
                if (r > 0)
                    res = gold + Dfs(r - 1, c);
                if (r + 1 < rows)
                    res = Math.Max(res, gold + Dfs(r + 1, c));
                if (c > 0)
                    res = Math.Max(res, gold + Dfs(r, c - 1));
                if (c + 1 < cols)
                    res = Math.Max(res, gold + Dfs(r, c + 1));
                grid[r][c] = gold;
                return res;
            }
        }
    }
}