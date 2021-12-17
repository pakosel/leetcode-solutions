using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace LargestPlusSign
{
    public class Solution
    {
        public int OrderOfLargestPlusSign(int n, int[][] mines)
        {
            var grid = CreateGrid(n, mines);

            var ones = new (int left, int up, int right, int down)[n][];
            for (int i = 0; i < n; i++)
                ones[i] = new (int, int, int, int)[n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    ones[i][j].left = j == 0 ? grid[i][j] : grid[i][j] == 0 ? 0 : ones[i][j - 1].left + 1;
                    ones[i][j].up   = i == 0 ? grid[i][j] : grid[i][j] == 0 ? 0 : ones[i - 1][j].up + 1;
                }
            for (int i = n - 1; i >= 0; i--)
                for (int j = n - 1; j >= 0; j--)
                {
                    ones[i][j].right = j == n - 1 ? grid[i][j] : grid[i][j] == 0 ? 0 : ones[i][j + 1].right + 1;
                    ones[i][j].down  = i == n - 1 ? grid[i][j] : grid[i][j] == 0 ? 0 : ones[i + 1][j].down + 1;
                }

            int max = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    max = Math.Max(max, Math.Min(
                                            Math.Min(ones[i][j].left, ones[i][j].up), 
                                            Math.Min(ones[i][j].right, ones[i][j].down)));
            return max;
        }

        private int[][] CreateGrid(int n, int[][] mines)
        {
            var grid = new int[n][];
            for (int i = 0; i < n; i++)
            {
                grid[i] = new int[n];
                Array.Fill(grid[i], 1);
            }
            foreach (var pair in mines)
                grid[pair[0]][pair[1]] = 0;

            return grid;
        }
    }
}