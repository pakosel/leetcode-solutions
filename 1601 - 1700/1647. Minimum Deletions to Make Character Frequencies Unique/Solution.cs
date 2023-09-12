using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MinimumDeletionsToMakeCharacterFrequenciesUnique
{
    public class Solution_2023
    {
        public int MinDeletions(string s)
        {
            var freq = new int[26];
            foreach (var c in s)
                freq[c - 'a']++;
            var pq = new PriorityQueue<int, int>();
            foreach (var f in freq)
                pq.Enqueue(f, f);
            var res = 0;
            var seen = new HashSet<int>();
            while (pq.Count > 0)
            {
                var curr = pq.Dequeue();
                while (curr > 0 && seen.Contains(curr))
                {
                    curr--;
                    res++;
                }
                seen.Add(curr);
            }
            return res;
        }
    }

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