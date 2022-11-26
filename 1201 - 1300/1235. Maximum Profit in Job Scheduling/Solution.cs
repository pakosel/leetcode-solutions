using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MaximumProfitInJobScheduling
{
    public class Solution
    {
        public int JobScheduling(int[] startTime, int[] endTime, int[] profit)
        {
            int len = startTime.Length;
            var jobs = new (int start, int end, int profit)[len];
            for (int i = 0; i < len; i++)
                jobs[i] = (startTime[i], endTime[i], profit[i]);
            Array.Sort(jobs, (j1, j2) => j1.start == j2.start ? j1.end.CompareTo(j2.end) : j1.start.CompareTo(j2.start));
            Array.Sort(startTime);

            var memo = new Dictionary<int, int>();
            var memoPos = new Dictionary<int, int>();

            return Memo(0);

            int Memo(int idx)
            {
                if (memo.ContainsKey(idx))
                    return memo[idx];
                if (idx == len)
                    return 0;

                var res = Math.Max(jobs[idx].profit + Memo(GetNextJobPos(jobs[idx].end)), Memo(idx + 1));
                memo.Add(idx, res);

                return res;
            }

            int GetNextJobPos(int pos)
            {
                if (memoPos.ContainsKey(pos))
                    return memoPos[pos];

                var idx = Array.BinarySearch(startTime, pos);
                if (idx > 0)
                    while (startTime[idx - 1] == pos)
                        idx--;
                else if (idx < 0)
                    idx = ~idx;

                memoPos.Add(pos, idx);
                return idx;
            }
        }
    }
}