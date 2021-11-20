using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MaxIncreaseToKeepCitySkyline
{
    public class Solution
    {
        public int MaxIncreaseKeepingSkyline(int[][] grid)
        {
            var len = grid.Length;
            var rowsMax = grid.Select(r => r.Max()).ToList();
            var colsMax = new int[len];

            for (int i = 0; i < len; i++)
                for (int j = 0; j < len; j++)
                    colsMax[j] = Math.Max(colsMax[j], grid[i][j]);

            var res = 0;
            for (int i = 0; i < len; i++)
                for (int j = 0; j < len; j++)
                {
                    var v = Math.Min(rowsMax[i], colsMax[j]) - grid[i][j];
                    if (v > 0)
                        res += v;
                }
            return res;
        }
    }
}