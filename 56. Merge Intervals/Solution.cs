using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MergeIntervals
{
    public class Solution
    {
        public int[][] Merge(int[][] intervals)
        {
            if (intervals.Length == 0)
                return intervals;
            Array.Sort(intervals, (i1, i2) => i1[0] != i2[0] ? i1[0].CompareTo(i2[0]) : i1[1].CompareTo(i2[1]));

            var res = new List<int[]>();
            int opening = intervals[0][0];
            int closing = intervals[0][1];
            for (int i = 1; i < intervals.Length; i++)
            {
                if (closing < intervals[i][0])
                {
                    res.Add(new int[] { opening, closing });
                    opening = intervals[i][0];
                    closing = intervals[i][1];
                }
                else
                    closing = Math.Max(closing, intervals[i][1]);
            }
            res.Add(new int[] { opening, closing });

            return res.ToArray();
        }
    }
}