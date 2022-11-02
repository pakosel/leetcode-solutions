using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace WhereWillTheBallFall
{
    public class Solution
    {
        public int[] FindBall(int[][] grid)
        {
            var rows = grid.Length;
            var cols = grid[0].Length;
            (int row, int col) cell = (0, 0);
            var res = new int[cols];

            for (int i = 0; i < cols; i++)
            {
                cell = (0, i);
                while (cell.row < rows)
                {
                    var curr = grid[cell.row][cell.col];
                    var prev = cell.col == 0 ? 1 : grid[cell.row][cell.col - 1];
                    var next = cell.col == cols - 1 ? -1 : grid[cell.row][cell.col + 1];
                    if ((curr == 1 && next == -1) || (curr == -1 && prev == 1))
                        break;
                    cell = (cell.row + 1, cell.col + curr);
                }
                res[i] = cell.row == rows ? cell.col : -1;
            }

            return res;
        }
    }
}