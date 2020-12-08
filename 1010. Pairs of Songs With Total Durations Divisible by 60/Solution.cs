using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace PairsOfSongsDivisibleBy60
{
    public class Solution
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        public int NumPairsDivisibleBy60(int[] time)
        {
            int res = 0;
            
            for (int i = 0; i < time.Length; i++)
            {
                int t = time[i] % 60;
                res += CountMatching((60 - t) % 60);
                AddToDict(t);
            }
            return res;
        }

        private void AddToDict(int val)
        {
            if (!dict.ContainsKey(val))
                dict.Add(val, 1);
            else
                dict[val]++;
        }

        private int CountMatching(int val)
        {
            if (dict.ContainsKey(val))
                return dict[val];

            return 0;
        }
    }
}