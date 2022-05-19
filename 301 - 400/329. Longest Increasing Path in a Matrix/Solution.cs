using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace LongestIncreasingPathInMatrix
{
    public class Solution
    {
        public int LongestIncreasingPath(int[][] matrix)
        {
            var m = matrix.Length;
            var n = matrix[0].Length;
            //init memo table
            var memo = Enumerable.Range(0, m).Select(_ => new int[n]).ToArray();

            var max = 0;
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    max = Math.Max(max, Dfs(i, j));

            return max;

            int Dfs(int i, int j)
            {
                if (memo[i][j] != 0)
                    return memo[i][j];
                var val = matrix[i][j];
                var res = 1;
                if (i > 0 && matrix[i - 1][j] > val)
                    res = Math.Max(res, Dfs(i - 1, j) + 1);
                if (i < m - 1 && matrix[i + 1][j] > val)
                    res = Math.Max(res, Dfs(i + 1, j) + 1);
                if (j > 0 && matrix[i][j - 1] > val)
                    res = Math.Max(res, Dfs(i, j - 1) + 1);
                if (j < n - 1 && matrix[i][j + 1] > val)
                    res = Math.Max(res, Dfs(i, j + 1) + 1);
                memo[i][j] = res;
                return res;
            }
        }
    }
}