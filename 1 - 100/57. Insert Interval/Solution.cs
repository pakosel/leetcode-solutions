using System.Collections.Generic;
using System.Linq;
using System;

namespace InsertInterval
{
    public class Solution_2022
    {
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            var n = intervals.Length;
            var arr = intervals.Select(i => i[0]).ToArray();
            var idx = Array.BinarySearch(arr, newInterval[0]);
            if (idx < 0)
                idx = ~idx;
            var res = new List<int[]>(n + 1);
            int i = 0;

            //copy first intervals (if any)
            for (i = 0; i < idx; i++)
                res.Add(intervals[i]);

            //add or merge the new interval
            if (res.Count > 0 && res.Last()[1] >= newInterval[0])
                res.Last()[1] = Math.Max(res.Last()[1], newInterval[1]);
            else
                res.Add(newInterval);

            //copy or merge all the rest
            while (i < n)
            {
                if (res.Last()[1] >= intervals[i][0])
                    res.Last()[1] = Math.Max(res.Last()[1], intervals[i][1]);
                else
                    res.Add(intervals[i]);
                i++;
            }
            
            return res.ToArray();
        }
    }

    public class Solution
    {
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            //edge cases
            if (intervals.Length == 0)
                return new int[][] { newInterval };

            var ret = new List<int[]>();
            var toMerge = new List<int[]>() { newInterval };
            var done = false;
            var idx = 0;
            while (idx < intervals.Length)
            {
                switch (CheckCase(intervals[idx], newInterval))
                {
                    case IntCase.INSERT:
                        ret.Add(intervals[idx]);
                        break;
                    case IntCase.MERGE:
                        toMerge.Add(intervals[idx]);
                        break;
                    case IntCase.ADD:
                        done = true;    //merging finished
                        break;
                    default:
                        break;
                }
                if (done)
                    break;
                idx++;
            }

            //add merged interval
            if (toMerge.Count > 0)
                ret.Add(Merge(toMerge));

            //add the rest of intervals
            for (int i = idx; i < intervals.Length; i++)
                ret.Add(intervals[i]);

            return ret.ToArray();
        }

        private int[] Merge(List<int[]> intervals)
        {
            var min = int.MaxValue;
            var max = int.MinValue;

            for (int i = 0; i < intervals.Count; i++)
            {
                if (intervals[i][0] < min)
                    min = intervals[i][0];
                if (intervals[i][1] > max)
                    max = intervals[i][1];
            }
            return new int[] { min, max };
        }

        private IntCase CheckCase(int[] interval1, int[] interval2)
        {
            if (interval1[1] < interval2[0])
                return IntCase.INSERT;
            if (interval1[0] > interval2[1])
                return IntCase.ADD;
            return IntCase.MERGE;
        }

        enum IntCase
        {
            INSERT, //insert on the left
            MERGE,
            ADD     //add on the right
        }
    }
}