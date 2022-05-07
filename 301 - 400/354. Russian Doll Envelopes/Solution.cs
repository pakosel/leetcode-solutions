using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Collections;

namespace RussianDollEnvelopes
{
    public class Solution
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
            for(int i=0; i<len; i++)
                max = Math.Max(max, Helper(envelopes, i));

            return max;
        }

        private int Helper(int[][] envelopes, int startIdx)
        {
            if(maxLen[startIdx] != 0)
                return maxLen[startIdx];
            
            int max = 1;
            for(int i=startIdx+1; i<envelopes.Length; i++)
                if(envelopes[startIdx][0] < envelopes[i][0] && envelopes[startIdx][1] < envelopes[i][1])
                    max = Math.Max(max, 1 + Helper(envelopes, i));
            
            maxLen[startIdx] = max;
            
            return max;
        }
    }
}