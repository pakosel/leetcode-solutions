using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Collections;

namespace RussianDollEnvelopes
{
    public class Solution_DP
    {
        public int MaxEnvelopes(int[][] envelopes)
        {
            var h = 0;
            var w = 0;
            foreach (var e in envelopes)
            {
                h = Math.Max(h, e[0]);
                w = Math.Max(w, e[1]);
            }
            h++;
            w++;
            var env = new HashSet<(int, int)>();
            foreach (var e in envelopes)
                env.Add((e[0], e[1]));
            var max = 0;
            var res = Enumerable.Range(0, h).Select(_ => new int[w]).ToArray();
            for (int i = 1; i < h; i++)
                for (int j = 1; j < w; j++)
                {
                    var up = (env.Contains((i - 1,j)) ? res[i - 1][j] - 1 : res[i - 1][j]);
                    var left = (env.Contains((i,j - 1)) ? res[i][j - 1] - 1 : res[i][j - 1]);
                    var diag = res[i - 1][j - 1];
                    res[i][j] = Math.Max(diag, Math.Max(up, left));
                    if (env.Contains((i,j)))
                        res[i][j]++;
                    max = Math.Max(max, res[i][j]);
                }
            return max;
        }
    }
    public class Solution_Memo
    {
        int[] maxLen;
        public int MaxEnvelopes(int[][] envelopes)
        {
            int len = envelopes.Length;
            if (len < 2)
                return len;

            maxLen = new int[len];
            Array.Sort(envelopes, (e1, e2) => e1[0] != e2[0] ? e1[0].CompareTo(e2[0]) : e1[1].CompareTo(e2[1]));

            int max = 0;
            for (int i = 0; i < len; i++)
                max = Math.Max(max, Helper(envelopes, i));

            return max;
        }

        private int Helper(int[][] envelopes, int startIdx)
        {
            if (maxLen[startIdx] != 0)
                return maxLen[startIdx];

            int max = 1;
            for (int i = startIdx + 1; i < envelopes.Length; i++)
                if (envelopes[startIdx][0] < envelopes[i][0] && envelopes[startIdx][1] < envelopes[i][1])
                    max = Math.Max(max, 1 + Helper(envelopes, i));

            maxLen[startIdx] = max;

            return max;
        }
    }
}