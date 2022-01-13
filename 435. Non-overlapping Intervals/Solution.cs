using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace NonoverlappingIntervals
{
    public class Solution
    {
        public int EraseOverlapIntervals(int[][] intervals)
        {
            Array.Sort(intervals, (i1, i2) => i1[1].CompareTo(i2[1]));
            var res = 0;
            var currEnd = intervals[0][1];
            for (int i = 1; i < intervals.Length; i++)
                if (intervals[i][0] < currEnd)
                    res++;
                else
                    currEnd = intervals[i][1];

            return res;
        }
    }
}