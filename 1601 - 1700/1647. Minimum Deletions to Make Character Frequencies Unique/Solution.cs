using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MinimumDeletionsToMakeCharacterFrequenciesUnique
{
    public class Solution
    {
        public int MinDeletions(string s)
        {
            var freq = new int[26];
            foreach(var c in s)
                freq[c-'a']++;
            Array.Sort(freq, (x, y) => y.CompareTo(x));
            var res = 0;
            for(int i=1; i<freq.Length && freq[i] > 0; i++)
                if(freq[i] >= freq[i-1])
                {
                    var diff = freq[i] - freq[i-1] + 1;
                    if(diff > freq[i])
                        diff = freq[i];
                    freq[i] -= diff;
                    res += diff;
                }
            return res;
        }
    }
}