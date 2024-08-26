using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MagicSquaresInGrid
{
    public class Solution
    {
        public int NumMagicSquaresInside(int[][] grid)
        {
            var rows = grid.Length;
            var cols = grid[0].Length;
            var res = 0;
            for (int r = 0; r < rows - 2; r++)
                for (int c = 0; c < cols - 2; c++)
                    res += Check(r, c);
            return res;

            int Check(int row, int col)
            {
                var arr = new int[10];
                for (int r = row; r < row + 3; r++)
                    for (int c = col; c < col + 3; c++)
                    {
                        var val = grid[r][c];
                        if (val < 1 || val > 9 || arr[val] > 0)
                            return 0;
                        else
                            arr[val]++;
                    }

                var sumRow0 = grid[row][col] + grid[row][col + 1] + grid[row][col + 2];
                if (grid[row][col] + grid[row + 1][col + 1] + grid[row + 2][col + 2] != sumRow0 ||
                   grid[row][col + 2] + grid[row + 1][col + 1] + grid[row + 2][col] != sumRow0)
                    return 0;

                for (int r = row + 1; r < row + 3; r++)
                    if (grid[r][col] + grid[r][col + 1] + grid[r][col + 2] != sumRow0)
                        return 0;

                for (int c = col; c < col + 3; c++)
                    if (grid[row][c] + grid[row + 1][c] + grid[row + 2][c] != sumRow0)
                        return 0;

                return 1;
            }
        }
    }
}