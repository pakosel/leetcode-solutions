using System.Collections.Generic;
using System.Linq;
using System;

namespace UniquePaths
{
    public class Solution
    {
        public int UniquePaths(int m, int n)
        {
            var arr = Enumerable.Range(0, m + 1).Select(_ => new int[n]).ToArray();
            arr[m][n - 1] = 1;
            for (int r = m - 1; r >= 0; r--)
                for (int c = n - 1; c >= 0; c--)
                    if (c == n - 1)
                        arr[r][c] = arr[r + 1][c];
                    else
                        arr[r][c] = arr[r + 1][c] + arr[r][c + 1];
            return arr[0][0];
        }
    }
    
    public class Solution_2021
    {
        public int UniquePaths(int m, int n)
        {
            if (m < 2 || n < 2)
                return 1;

            int[,] arr = new int[m, n];

            for (int i = 0; i < m; i++)
                arr[i, n - 1] = 1;
            for (int j = 0; j < n; j++)
                arr[m - 1, j] = 1;

            for (int i = m - 2; i >= 0; i--)
                for (int j = n - 2; j >= 0; j--)
                    arr[i, j] = arr[i + 1, j] + arr[i, j + 1];

            return arr[0, 0];
        }
    }
}