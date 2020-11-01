using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace SubstringConcatenationAllWords
{
    public class Solution
    {
        int wordLen;

        public IList<int> FindSubstring(string s, string[] words)
        {
            wordLen = words[0].Length;
            int concatLen = wordLen * words.Length;

            List<int> res = new List<int>();
            if (s.Length < concatLen)
                return res;

            for (int i = 0; i <= s.Length - concatLen; i++)
                if (CheckString(s.Substring(i), words))
                    res.Add(i);

            return res;
        }

        private bool CheckString(string s, IEnumerable<string> words)
        {
            if (words.Count() == 0)
                return true;

            string word = s.Substring(0, wordLen);
            int cnt = words.Count(w => w == word);
            if (cnt == 0)
                return false;
            var newWords = words.Where(w => w != word);
            for (int i = 1; i < cnt; i++)
                newWords = newWords.Append(word);

            return CheckString(s.Substring(wordLen), newWords);
        }
    }
}