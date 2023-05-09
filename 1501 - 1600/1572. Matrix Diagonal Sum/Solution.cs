using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MatrixDiagonalSum
{
    public class Solution
    {
        public int DiagonalSum(int[][] mat)
        {
            var len = mat.Length;
            var res = 0;
            for (int i = 0; i < len; i++)
            {
                res += mat[i][i];
                res += mat[len - i - 1][i];
            }
            if (len % 2 == 1)
                res -= mat[len / 2][len / 2];
            return res;
        }
    }
}