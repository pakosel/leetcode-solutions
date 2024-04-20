using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace FindAllGroupsOfFarmland
{
    public class Solution
    {
        public int[][] FindFarmland(int[][] land)
        {
            var res = new List<int[]>();
            int rows = land.Length, cols = land[0].Length;

            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols; c++)
                    if (land[r][c] == 1 && (r == 0 || land[r - 1][c] == 0))
                    {
                        int r2 = r, c2 = c;
                        while (r2 + 1 < rows && land[r2 + 1][c] == 1)
                            r2++;
                        while (c2 + 1 < cols && land[r][c2 + 1] == 1)
                            c2++;
                        res.Add(new int[4] { r, c, r2, c2 });
                        c = c2;
                    }
            return res.ToArray();
        }
    }
}