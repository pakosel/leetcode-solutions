using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace DataStreamAsDisjointIntervals
{
    public class SummaryRanges
    {
        List<int[]> _intervals;
        public SummaryRanges()
        {
            _intervals = new List<int[]>();
        }

        public void AddNum(int value)
        {
            var idx = GetInterval(value);
            if(idx > _intervals.Count - 1)  //append intervals and merge if required (below)
                _intervals.Add(new int[] {value, value});
            else
            {
                var currInterval = _intervals[idx];
                if(currInterval[0] <= value && currInterval[1] >= value)    //put value into existing interval
                    return;
                _intervals.Insert(idx, new int[] {value, value});
            }
            Merge(idx);
        }

        private void Merge(int idx)
        {
            var curr = _intervals[idx];
            var next = idx + 1 <= _intervals.Count-1 ? _intervals[idx+1] : null;

            if(next != null && next[0] - curr[1] == 1)
            {
                curr[1] = next[1];
                _intervals.RemoveAt(idx+1);
            }

            var prev = idx - 1 >= 0 ? _intervals[idx-1] : null;
            if(prev != null && curr[0] - prev[1] == 1)
            {
                prev[1] = curr[1];
                _intervals.RemoveAt(idx);
            }
        }

        public int[][] GetIntervals() => _intervals.ToArray();

        public SummaryRanges(int[][] intervals)
        {
            _intervals = intervals.ToList<int[]>();
        }

        public int GetInterval(int num)
        {
            var idx = _intervals.BinarySearch(new int[] {num, num}, 
                            Comparer<int[]>.Create((i1, i2) => i1[0] <= i2[0] && i1[1] >= i2[1]? 0 : i1[0] < i2[1] ? -1 : 1));
            if(idx < 0)
                idx = ~idx;
            return idx;
        }
    }
}