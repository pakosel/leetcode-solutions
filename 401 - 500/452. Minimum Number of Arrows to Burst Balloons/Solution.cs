using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MinimumNumberOfArrowsToBurstBalloons
{
    public class Solution
    {
        public int FindMinArrowShots(int[][] points)
        {
            Array.Sort(points, (e1, e2) => e1[1].CompareTo(e2[1]));

            var res = 1;
            var currEnd = points[0][1];
            foreach (var p in points)
            {
                var start = p[0];
                var end = p[1];
                if (start > currEnd)
                {
                    res++;
                    currEnd = end;
                }
            }

            return res;
        }
    }
}