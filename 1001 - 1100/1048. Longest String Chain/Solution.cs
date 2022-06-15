using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace LongestStringChain
{
    public class Solution
    {
        public int LongestStrChain(string[] words)
        {
            var memo = new Dictionary<string, int>();
            var dict = words.GroupBy(w => w.Length).ToDictionary(g => g.Key, g => g.ToList());

            return words.Max(w => MaxChain(w));

            int MaxChain(string word)
            {
                if(memo.ContainsKey(word))
                    return memo[word];

                var res = 1;
                if(dict.ContainsKey(word.Length + 1))
                    foreach(var w2 in dict[word.Length + 1])
                        if(IsPredecessor(word, w2))
                            res = Math.Max(res, 1 + MaxChain(w2));
                memo.Add(word, res);
                
                return res;
            }

            bool IsPredecessor(string w1, string w2)
            {
                //length is checked in MaxChain method
                var gotErr = false;
                for (int i = 0, j = 0; i < w1.Length && j < w2.Length; j++)
                    if (w1[i] == w2[j])
                        i++;
                    else if (!gotErr)
                        gotErr = true;
                    else
                        return false;

                return true;
            }
        }
    }
}