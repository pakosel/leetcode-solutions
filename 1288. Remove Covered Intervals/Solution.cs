using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace RemoveCoveredIntervals
{
    public class Solution
    {
        public int RemoveCoveredIntervals(int[][] intervals)
        {
            Array.Sort(intervals, (x, y) => x[0] == y[0] ? x[1].CompareTo(y[1]) : x[0].CompareTo(y[0]));
            var curr = intervals[0];
            var res = 1;
            var i = 1;
            while (i < intervals.Length)
            {
                if (intervals[i][1] > curr[1])
                {
                    if (curr[0] < intervals[i][0])
                        res++;
                    curr = intervals[i];
                }
                i++;
            }
            return res;
        }
    }
}