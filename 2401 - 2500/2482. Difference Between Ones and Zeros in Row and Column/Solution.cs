using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace DifferenceBetweenOnesAndZerosInRowAndColumn
{
    public class Solution
    {
        public int[][] OnesMinusZeros(int[][] grid)
        {
            var rowOnes = new int[grid.Length];
            var colOnes = new int[grid[0].Length];

            for (int r = 0; r < grid.Length; r++)
                for (int c = 0; c < grid[0].Length; c++)
                    if (grid[r][c] == 1)
                    {
                        rowOnes[r]++;
                        colOnes[c]++;
                    }
            var res = new int[grid.Length][];
            var sum = grid.Length + grid[0].Length;

            for (int r = 0; r < grid.Length; r++)
            {
                res[r] = new int[grid[0].Length];
                for (int c = 0; c < grid[0].Length; c++)
                    res[r][c] = 2 * rowOnes[r] + 2 * colOnes[c] - sum;
            }
            return res;
        }
    }
}