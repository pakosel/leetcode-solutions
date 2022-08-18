using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace SubstringConcatenationAllWords
{
    //improved version of _TLE solution
    public class Solution
    {
        public IList<int> FindSubstring(string s, string[] words)
        {
            int len = s.Length;
            int wordLen = words[0].Length;
            int concatLen = wordLen * words.Length;

            List<int> res = new List<int>();
            if (len < concatLen)
                return res;
            var allWords = new Dictionary<string, int>();
            foreach (var w in words)
                if (allWords.ContainsKey(w))
                    allWords[w]++;
                else
                    allWords.Add(w, 1);

            var wordsList = new Dictionary<string, int>(allWords);
            var wordsCnt = 0;

            int left = 0;
            int right = wordLen;

            while (left < len && right < len + 1)
            {
                var sub = s.Substring(right - wordLen, wordLen);
                if (wordsList.ContainsKey(sub) && wordsList[sub] > 0)
                {
                    wordsList[sub]--;
                    wordsCnt++;
                    if (wordsCnt == words.Length)
                    {
                        res.Add(left);
                        left++;
                        right = left + wordLen;
                        wordsList = new Dictionary<string, int>(allWords);
                        wordsCnt = 0;
                    }
                    else
                        right += wordLen;
                }
                else
                {
                    left++;
                    right = left + wordLen;
                    wordsList = new Dictionary<string, int>(allWords);
                    wordsCnt = 0;
                }
            }

            return res;
        }
    }

    public class Solution_TLE
    {
        public IList<int> FindSubstring(string s, string[] words)
        {
            int len = s.Length;
            int wordLen = words[0].Length;
            int concatLen = wordLen * words.Length;

            List<int> res = new List<int>();
            if (len < concatLen)
                return res;

            var wordsList = words.ToList();

            int left = 0;
            int right = wordLen;

            while (left < len && right < len + 1)
            {
                var sub = s.Substring(right - wordLen, wordLen);
                if (wordsList.Contains(sub))
                {
                    wordsList.Remove(sub);
                    if (wordsList.Count == 0)
                    {
                        res.Add(left);
                        left++;
                        right = left + wordLen;
                        wordsList = words.ToList();
                        // wordsList.Add(s.Substring(left, wordLen));
                        // left += wordLen;
                        // right += wordLen;
                    }
                    else
                        right += wordLen;
                }
                else
                {
                    left++;
                    right = left + wordLen;
                    wordsList = words.ToList();
                }
            }

            return res;
        }
    }
}