using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MinimumTimeVisitingAllPoints
{
    public class Solution
    {
        public int MinTimeToVisitAllPoints(int[][] points)
        {
            var res = 0;
            for (int i = 1; i < points.Length; i++)
                res += Dist(points[i - 1], points[i]);
            return res;

            int Dist(int[] p1, int[] p2) => Math.Max(Math.Abs(p2[0] - p1[0]), Math.Abs(p2[1] - p1[1]));
        }
    }
}