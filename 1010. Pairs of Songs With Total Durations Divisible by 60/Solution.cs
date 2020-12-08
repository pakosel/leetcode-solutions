using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace PairsOfSongsDivisibleBy60
{
    public class Solution
    {
        int[] dict = new int[60];

        public int NumPairsDivisibleBy60(int[] time)
        {
            int res = 0;
            
            for (int i = 0; i < time.Length; i++)
            {
                int t = time[i] % 60;
                res += dict[(60 - t) % 60];
                dict[t]++;
            }
            return res;
        }
    }
}