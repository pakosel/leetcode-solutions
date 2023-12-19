using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ImageSmoother
{
    public class Solution
    {
        public int[][] ImageSmoother(int[][] img)
        {
            int rows = img.Length;
            int cols = img[0].Length;
            var res = new int[rows][];

            for (int r = 0; r < rows; r++)
            {
                res[r] = new int[cols];
                for (int c = 0; c < cols; c++)
                    res[r][c] = Calc(r, c);
            }
            return res;

            int Calc(int row, int col)
            {
                var res = 0;
                var cnt = 0;
                for (int r = row - 1; r <= row + 1; r++)
                    for (int c = col - 1; c <= col + 1; c++)
                        if (r >= 0 && r < rows && c >= 0 && c < cols)
                        {
                            res += img[r][c];
                            cnt++;
                        }
                return res / cnt;
            }
        }
    }
}