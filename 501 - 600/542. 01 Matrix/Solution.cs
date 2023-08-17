using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace Matrix01
{
    public class Solution
    {
        public int[][] UpdateMatrix(int[][] mat)
        {
            const int MAX = 1_000_000;
            var rows = mat.Length;
            var cols = mat[0].Length;
            var res = Enumerable.Range(0, rows).Select(_ => new int[cols]).ToArray();

            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols; c++)
                    res[r][c] = mat[r][c] == 0 ? 0 : MAX;

            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols; c++)
                {
                    if (r > 0)
                        res[r][c] = Math.Min(res[r][c], res[r - 1][c] + 1);
                    if (c > 0)
                        res[r][c] = Math.Min(res[r][c], res[r][c - 1] + 1);
                }
            for (int r = rows - 1; r >= 0; r--)
                for (int c = cols - 1; c >= 0; c--)
                {
                    if (r < rows - 1)
                        res[r][c] = Math.Min(res[r][c], res[r + 1][c] + 1);
                    if (c < cols - 1)
                        res[r][c] = Math.Min(res[r][c], res[r][c + 1] + 1);
                }
            return res;
        }
    }
}