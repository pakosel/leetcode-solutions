using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MinimumFallingPathSum
{
    public class Solution
    {
        const int MAX = 1_000_000;
        public int MinFallingPathSum(int[][] matrix)
        {
            var n = matrix.Length;
            var res = Enumerable.Range(0, n).Select(_ => new int[n]).ToArray();
            for (int c = 0; c < n; c++)
                res[n - 1][c] = matrix[n - 1][c];

            for (int r = n - 2; r >= 0; r--)
                for (int c = 0; c < n; c++)
                {
                    var prev1 = c == 0 ? MAX : res[r + 1][c - 1];
                    var prev2 = res[r + 1][c];
                    var prev3 = c == n - 1 ? MAX : res[r + 1][c + 1];

                    res[r][c] = matrix[r][c] + Math.Min(prev1, Math.Min(prev2, prev3));
                }
            return res[0].Min(_ => _);
        }
    }
}