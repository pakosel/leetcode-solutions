using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace PairsOfSongsDivisibleBy60
{
    public class Solution
    {
        Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
        int max = 0;

        public int NumPairsDivisibleBy60(int[] time)
        {
            int res = 0;
            BuildDict(time);
            for (int i = 0; i < time.Length; i++)
                res += CountMatching(time[i], i);
            return res;
        }

        private void BuildDict(int[] time)
        {
            for (int i = 0; i < time.Length; i++)
            {
                int t = time[i];
                if (!dict.ContainsKey(t))
                    dict.Add(t, new List<int>());
                dict[t].Add(i);
                max = Math.Max(max, t);
            }
        }

        private int CountMatching(int val, int idx)
        {
            int res = 0;
            int div = 60;
            while (div <= 2 * max)
            {
                int check = div - val;
                if (check > 0 && dict.ContainsKey(check))
                    res += dict[check].Count(i => i < idx);
                div += 60;
            }

            return res;
        }
    }
}