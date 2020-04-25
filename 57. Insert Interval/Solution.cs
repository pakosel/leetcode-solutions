using System.Collections.Generic;
using System.Linq;
using System;

namespace InsertInterval
{
    public class Solution
    {
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            //edge cases
            if(intervals.Length == 0)
                return new int[][] { newInterval };

            var ret = new List<int[]>();
            var toMerge = new List<int[]>();
            var done = false;
            var idx=0;
            while(idx < intervals.Length)
            {
                switch(CheckCase(intervals[idx], newInterval))
                {
                    case IntCase.ADD:
                        if(toMerge.Count > 0)
                            ret.Add(Merge(toMerge));
                        else
                            ret.Add(newInterval);
                        toMerge.Clear();
                        done = true;
                        break;
                    case IntCase.MERGE:
                        toMerge.Add(intervals[idx]);
                        toMerge.Add(newInterval);
                        break;
                    case IntCase.SKIP:
                        toMerge.Add(newInterval);
                        break;
                    case IntCase.OVERLAP:
                        done = true;
                        break;
                    case IntCase.INSERT:
                        ret.Add(intervals[idx]);
                        break;
                    default:
                        break;
                }
                if(done)
                    break;
                idx++;
            }
                
            if(toMerge.Count > 0)
                ret.Add(Merge(toMerge));


            for(int i=idx; i<intervals.Length; i++)
                ret.Add(intervals[i]);

            if(ret.Last()[1] < newInterval[0])
                ret.Add(newInterval);

            return ret.ToArray();
        }

        private int[] Merge(List<int[]> intervals)
        {
            var min = int.MaxValue;
            var max = int.MinValue;
            
            for(int i=0; i<intervals.Count; i++)
            {
                if(intervals[i][0] < min)
                    min = intervals[i][0];
                if(intervals[i][1] > max)
                    max = intervals[i][1];
            }
            return new int[] { min, max };
        }

        private IntCase CheckCase(int[] interval1, int[] interval2)
        {
            if(interval1[0] < interval2[0])
            {
                if(interval1[1] < interval2[0])
                    return IntCase.INSERT;
                else if(interval1[1] < interval2[1])
                    return IntCase.MERGE;
                else // interval1[1] >= interval2[1]
                    return IntCase.OVERLAP;
            }
            else if(interval1[0] == interval2[0])
            {
                if(interval1[1] <= interval2[1])
                    return IntCase.SKIP;
                else
                    return IntCase.MERGE;
            }
            else
            {
                if(interval1[1] <= interval2[1])
                    return IntCase.SKIP;
                else if(interval1[0] <= interval2[1])
                    return IntCase.MERGE;
                else
                    return IntCase.ADD;
            }

        }

        enum IntCase
        {
            INSERT,
            MERGE,
            SKIP,
            ADD,
            OVERLAP
        }
    }
}