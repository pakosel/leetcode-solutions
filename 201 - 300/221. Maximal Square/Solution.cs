using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MaximalSquare
{
    //modified solution for # 85. Maximal Rectangle
    public class Solution
    {
        public int MaximalSquare(char[][] matrix)
        {
            int h = matrix.Length;
            if (h == 0)
                return 0;
            int w = matrix[0].Length;

            //for each position calculate how many 1's are up and left from current pos
            var arr = new (int up, int left)[h][];
            int max = 0;

            for (int i = 0; i < h; i++)
            {
                arr[i] = new (int, int)[w];
                for (int j = 0; j < w; j++)
                {
                    if (matrix[i][j] == '0')
                        arr[i][j] = (0, 0);
                    else
                    {
                        var up = i > 0 ? arr[i - 1][j].up + 1 : 1;
                        var left = j > 0 ? arr[i][j - 1].left + 1 : 1;
                        arr[i][j] = (up, left);
                        var localMax = 1;
                        //find potential rectangles upward
                        for (int x = 1; x < up; x++)
                        {
                            left = Math.Min(left, arr[i - x][j].left);
                            var factor = Math.Min(left, x + 1);
                            localMax = Math.Max(localMax, factor * factor);
                            if (factor < x)
                                break;
                        }
                        max = Math.Max(max, localMax);
                    }
                }
            }
            return max;
        }
    }
}