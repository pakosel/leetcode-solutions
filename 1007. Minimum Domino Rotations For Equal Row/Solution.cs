using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MinimumDominoRotationsForEqualRow
{
    public class Solution
    {
        public int MinDominoRotations(int[] tops, int[] bottoms)
        {
            var fromTop = Try(tops, bottoms, tops[0]);
            var fromBottom = Try(tops, bottoms, bottoms[0]);
            var res = Math.Min(fromTop, fromBottom);

            return res != int.MaxValue ? res : -1;
        }

        private int Try(int[] tops, int[] bottoms, int val)
        {
            var t = 0;
            var b = 0;
            for (int i = 0; i < tops.Length; i++)
                if (tops[i] == val && bottoms[i] == val)
                    continue;
                else if (tops[i] == val)
                    t++;
                else if (bottoms[i] == val)
                    b++;
                else
                    return int.MaxValue;

            return Math.Min(t, b);
        }
    }
}