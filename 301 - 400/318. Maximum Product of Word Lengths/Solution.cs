using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MaximumProductOfWordLengths
{
    public class Solution
    {
        public int MaxProduct(string[] words)
        {
            var arr = words.Select(w => StrToNum(w)).ToArray();
            
            var max = 0;
            for (int i = 0; i < words.Length; i++)
                for (int j = i + 1; j < words.Length; j++)
                    if ((arr[i] & arr[j]) == 0)
                        max = Math.Max(max, words[i].Length * words[j].Length);
            return max;

            int StrToNum(string s)
            {
                var res = 0;
                foreach (var c in s)
                    res |= (1 << (c - 'a'));
                return res;
            }
        }
    }
}