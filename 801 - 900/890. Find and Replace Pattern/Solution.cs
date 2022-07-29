using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace FindAndReplacePattern
{
    public class Solution
    {
        public IList<string> FindAndReplacePattern(string[] words, string pattern)
        {
            var res = new List<string>();
            foreach (var word in words)
                if (word.Length == pattern.Length && Match(word))
                    res.Add(word);
            return res;

            bool Match(string word)
            {
                var dictP = new Dictionary<char, int>();
                var dictW = new Dictionary<char, int>();
                for (int i = 0; i < pattern.Length; i++)
                    if (!dictP.ContainsKey(pattern[i]) && !dictW.ContainsKey(word[i]))
                    {
                        dictP.Add(pattern[i], word[i] - pattern[i]);
                        dictW.Add(word[i], word[i] - pattern[i]);
                    }
                    else if (!dictP.ContainsKey(pattern[i]) || !dictW.ContainsKey(word[i]) || dictW[word[i]] != dictP[pattern[i]])
                        return false;
                return true;
            }
        }
    }
}