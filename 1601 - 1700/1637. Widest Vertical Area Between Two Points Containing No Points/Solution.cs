using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace WidestVerticalAreaBetweenTwoPointsContainingNoPoints
{
    public class Solution
    {
        public int MaxWidthOfVerticalArea(int[][] points)
        {
            Array.Sort(points, (x, y) => x[0].CompareTo(y[0]));

            var res = 0;

            for (int i = 1; i < points.Length; i++)
                res = Math.Max(res, points[i][0] - points[i - 1][0]);
            return res;
        }
    }
}