using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace TwoFurthestHousesWithDifferentColors
{
    public class Solution
    {
        public int MaxDistance(int[] colors)
        {
            var max = 0;
            var last = colors.Length - 1;
            var i = last;
            while (colors[0] == colors[i] && i > 0)
                i--;
            max = i;
            i = 0;
            while (colors[i] == colors[last])
                i++;
            max = Math.Max(max, last - i);

            return max;
        }
    }
}