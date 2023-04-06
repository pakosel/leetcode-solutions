using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace NumberOfClosedIslands
{
    public class Solution
    {
        public int ClosedIsland(int[][] grid)
        {
            var rows = grid.Length;
            var cols = grid[0].Length;
            var visited = Enumerable.Range(0, rows).Select(_ => new bool[cols]).ToArray();

            //exclude islands starting in first or last row
            for (int i = 0; i < cols; i++)
            {
                Dfs(0, i);
                Dfs(rows - 1, i);
            }
            //exclude islands starting in first or last column
            for (int i = 0; i < rows; i++)
            {
                Dfs(i, 0);
                Dfs(i, cols - 1);
            }

            //count remaining not visited islands
            var res = 0;
            for (int r = 1; r < rows - 1; r++)
                for (int c = 1; c < cols - 1; c++)
                    if (!visited[r][c] && grid[r][c] == 0)
                    {
                        res++;
                        Dfs(r, c);
                    }
            return res;

            void Dfs(int row, int col)
            {
                if (row < 0 || row == rows || col < 0 || col == cols ||
                   visited[row][col] || grid[row][col] == 1)
                    return;
                visited[row][col] = true;
                Dfs(row + 1, col);
                Dfs(row - 1, col);
                Dfs(row, col + 1);
                Dfs(row, col - 1);
            }
        }
    }
}