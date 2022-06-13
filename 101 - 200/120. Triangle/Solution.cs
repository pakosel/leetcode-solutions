using System.Collections.Generic;
using System.Linq;
using System;

namespace Triangle
{
    public class Solution
    {
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            var memo = new Dictionary<(int row, int col), int>();

            return MinPath(0, 0);

            int MinPath(int row, int col)
            {
                if (memo.ContainsKey((row, col)))
                    return memo[(row, col)];
                var res = triangle[row][col];
                if (row < triangle.Count - 1)
                    res += Math.Min(MinPath(row + 1, col), MinPath(row + 1, col + 1));
                memo.Add((row, col), res);

                return res;
            }
        }
    }
}