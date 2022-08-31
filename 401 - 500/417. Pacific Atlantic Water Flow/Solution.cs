using System.Collections.Generic;
using System.Linq;
using System;

namespace PacificAtlanticWaterFlow
{
    public class Solution
    {
        public IList<IList<int>> PacificAtlantic(int[][] heights)
        {
            var m = heights.Length;
            var n = heights[0].Length;
            var pacific = Enumerable.Range(0, m).Select(r => new bool[n]).ToArray();
            var atlantic = Enumerable.Range(0, m).Select(r => new bool[n]).ToArray();

            for (int i = 0; i < m; i++)
            {
                Dfs(i, 0, pacific);
                Dfs(i, n - 1, atlantic);
            }
            for (int j = 0; j < n; j++)
            {
                Dfs(0, j, pacific);
                Dfs(m - 1, j, atlantic);
            }

            var res = new List<IList<int>>();
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    if (pacific[i][j] && atlantic[i][j])
                        res.Add(new int[] { i, j });

            return res;

            void Dfs(int r, int c, bool[][] tab)
            {
                if (tab[r][c])
                    return;
                tab[r][c] = true;
                if (r - 1 >= 0 && heights[r - 1][c] >= heights[r][c])
                    Dfs(r - 1, c, tab);
                if (r + 1 < m && heights[r + 1][c] >= heights[r][c])
                    Dfs(r + 1, c, tab);
                if (c - 1 >= 0 && heights[r][c - 1] >= heights[r][c])
                    Dfs(r, c - 1, tab);
                if (c + 1 < n && heights[r][c + 1] >= heights[r][c])
                    Dfs(r, c + 1, tab);
            }
        }
    }
}