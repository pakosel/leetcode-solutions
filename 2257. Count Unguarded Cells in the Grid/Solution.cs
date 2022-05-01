using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace CountUnguardedCellsInTheGrid
{
    public class Solution
    {
        public int CountUnguarded(int m, int n, int[][] guards, int[][] walls)
        {
            var grid = new int[m][];
            for (int i = 0; i < m; i++)
                grid[i] = new int[n];
            foreach (var w in walls)
                grid[w[0]][w[1]] = -1;
            foreach (var g in guards)
            {
                var r = g[0];
                var c = g[1];
                grid[r][c] = -2;
                for (int i = r - 1; i >= 0; i--)
                {
                    var v = grid[i][c];
                    if (v < 0 || v == 1)    //wall, guard, ⇵
                        break;
                    grid[i][c] = 1; //⇵
                }
                for (int i = r + 1; i < m; i++)
                {
                    var v = grid[i][c];
                    if (v < 0 || v == 1)    //wall, guard, ⇵
                        break;
                    grid[i][c] = 1; //⇵
                }
                for (int i = c - 1; i >= 0; i--)
                {
                    var v = grid[r][i];
                    if (v < 0 || v == 2)    //wall, guard, ⟷
                        break;
                    grid[r][i] = 2; //⟷
                }
                for (int i = c + 1; i < n; i++)
                {
                    var v = grid[r][i];
                    if (v < 0 || v == 2)    //wall, guard, ⟷
                        break;
                    grid[r][i] = 2; //⟷
                }
            }
            return grid.Sum(r => r.Count(c => c == 0));
        }
    }
}