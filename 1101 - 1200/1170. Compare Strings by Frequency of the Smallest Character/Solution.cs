using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace CompareStringsByFrequencyOfTheSmallestCharacter
{
    public class Solution
    {
        public int[] NumSmallerByFrequency(string[] queries, string[] words)
        {
            var memo = new Dictionary<string, int>();
            var wordsF = new int[words.Length];
            int i = 0;
            foreach (var w in words)
                wordsF[i++] = f(w);
            Array.Sort(wordsF);

            var res = new int[queries.Length];
            i = 0;
            foreach (var q in queries)
            {
                var qF = f(q);
                var idx = Array.BinarySearch(wordsF, qF);

                if (idx < 0)
                    idx = ~idx;
                while (idx < wordsF.Length && wordsF[idx] <= qF)
                    idx++;

                res[i++] = wordsF.Length - idx;
            }

            return res;

            int f(string s)
            {
                if (memo.ContainsKey(s))
                    return memo[s];
                var minChar = s[0];
                var res = 1;
                for (int i = 1; i < s.Length; i++)
                    if (s[i] < minChar)
                    {
                        minChar = s[i];
                        res = 1;
                    }
                    else if (s[i] == minChar)
                        res++;
                memo.Add(s, res);
                return res;
            }
        }
    }
}