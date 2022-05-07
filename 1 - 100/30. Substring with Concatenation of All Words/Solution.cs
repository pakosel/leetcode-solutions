using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace SubstringConcatenationAllWords
{
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

            var wordsList = words.ToList();

            int left = 0;
            int right = wordLen;

            while(left < len && right < len+1)
            {
                var sub = s.Substring(right - wordLen, wordLen);
                if(wordsList.Contains(sub))
                {
                    wordsList.Remove(sub);
                    if(wordsList.Count == 0)
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