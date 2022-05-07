using System.Collections.Generic;
using System.Linq;
using System;

namespace Search2DMatrix
{
    public class Solution
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int i = 0;
            while (i < matrix.Length - 1 && matrix[i][0] < target)
                i++;
            if (i > 0 && matrix[i][0] > target)
                i--;

            return matrix[i].Contains(target);
        }
    }
}