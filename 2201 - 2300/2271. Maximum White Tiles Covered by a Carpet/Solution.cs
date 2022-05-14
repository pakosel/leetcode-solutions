using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MaximumWhiteTilesCoveredByCarpet
{
    public class Solution
    {
        public int MaximumWhiteTiles(int[][] tiles, int carpetLen)
        {
            Array.Sort(tiles, (t1, t2) => t1[0].CompareTo(t2[0]));
            var len = tiles.Length;
            var max = 0;
            for (int i = 0; i < len; i++)
            {
                var start = tiles[i][0];
                var end = start + carpetLen - 1;
                var curr = 0;
                int j;
                for (j = i; j < len && tiles[j][0] <= end; j++)
                {
                    var last = Math.Min(tiles[j][1], end);
                    curr += (last - tiles[j][0] + 1);
                }

                max = Math.Max(max, curr);
                if (max == carpetLen || j == len)
                    break;
            }

            return max;
        }
    }
}