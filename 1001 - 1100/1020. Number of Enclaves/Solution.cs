using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace NumberOfEnclaves
{
    public class Solution
    {
        public int NumEnclaves(int[][] grid)
        {
            var rows = grid.Length;
            var cols = grid[0].Length;

            //remove all land starting with 1st or last row
            for (int i = 0; i < cols; i++)
            {
                Dfs(0, i);
                Dfs(rows - 1, i);
            }

            //remove all land starting with 1st or last column
            for (int i = 0; i < rows; i++)
            {
                Dfs(i, 0);
                Dfs(i, cols - 1);
            }

            //count remaining land cells
            var res = 0;
            for (int r = 1; r < rows; r++)
                for (int c = 1; c < cols; c++)
                    res += grid[r][c];
            return res;

            void Dfs(int row, int col)
            {
                if (row < 0 || row == rows || col < 0 || col == cols || grid[row][col] == 0)
                    return;
                grid[row][col] = 0;

                Dfs(row + 1, col);
                Dfs(row - 1, col);
                Dfs(row, col + 1);
                Dfs(row, col - 1);
            }
        }
    }
}