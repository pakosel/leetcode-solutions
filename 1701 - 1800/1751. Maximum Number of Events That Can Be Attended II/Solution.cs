using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MaximumNumberOfEventsThatCanBeAttendedII
{
    public class Solution
    {
        public int MaxValue(int[][] events, int k)
        {
            Array.Sort(events, Comparer<int[]>.Create((x, y) => x[0] != y[0] ? x[0].CompareTo(y[0]) : x[1].CompareTo(y[1])));

            var memo = new Dictionary<(int start, int k), int>();

            return Memo(0, k, 0);

            int Memo(int idx, int k, int begin)
            {
                if (k == 0)
                    return 0;
                while (idx < events.Length && events[idx][0] < begin)
                    idx++;
                if (idx >= events.Length)
                    return 0;
                var key = (idx, k);
                if (memo.ContainsKey(key))
                    return memo[key];
                var res = 0;
                if (k == 1)
                    for (int i = idx; i < events.Length; i++)
                        res = Math.Max(res, events[i][2]);
                else
                    res = Math.Max(events[idx][2] + Memo(idx + 1, k - 1, events[idx][1] + 1), Memo(idx + 1, k, begin));
                memo[key] = res;

                return res;
            }
        }
    }
}