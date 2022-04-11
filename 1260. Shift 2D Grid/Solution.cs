using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace Shift2DGrid
{
    public class Solution
    {
        public IList<IList<int>> ShiftGrid(int[][] grid, int k)
        {
            var h = grid.Length;
            var w = grid[0].Length;
            k %= (w * h);
            
            var res = new int[h][];
            for (int i = 0; i < h; i++)
                res[i] = new int[w];

            var pos = 0;
            for (int i = 0; i < h; i++)
                for (int j = 0; j < w; j++)
                {
                    var sh = Shift((pos + k) % (w * h), w);
                    res[sh.i][sh.j] = grid[i][j];
                    pos++;
                }

            return res;
        }

        private (int i, int j) Shift(int pos, int w) => (pos / w, pos % w);
    }

}