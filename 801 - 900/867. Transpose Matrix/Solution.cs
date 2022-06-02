using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;
using LowestCommonAncestorDeepestLeaves;

namespace TransposeMatrix
{
    public class Solution
    {
        public int[][] Transpose(int[][] matrix)
        {
            var m = matrix.Length;
            var n = matrix[0].Length;
            var res = Enumerable.Range(0, n).Select(_ => new int[m]).ToArray();
            for(int i=0; i<m; i++)
                for(int j=0; j<n; j++)
                    res[j][i] = matrix[i][j];
            return res;
        }
    }
}