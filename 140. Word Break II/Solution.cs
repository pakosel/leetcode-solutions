using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace WordBreakII
{
    public class Solution
    {
        public IList<string> WordBreak(string s, IList<string> wordDict)
        {
            var res = new List<string>();
            foreach(var c in s)
                if(!wordDict.Any(w => w.Contains(c)))
                    return res;

            var maxWordLen = wordDict.Max(w => w.Length);
            var minWordLen = wordDict.Min(w => w.Length);

            BreakNextWords("", s, wordDict, res, minWordLen, maxWordLen);
            return res;
        }

        private void BreakNextWords(string candidate, string s, IList<string> wordDict, IList<string> res, int minWordLen, int maxWordLen)
        {
            if(candidate.Length > 0 && s.Length == 0)
            {
                res.Add(candidate.Trim());
                return;
            }

            for (int i = minWordLen; i <= maxWordLen; i++)
            {
                if(i > s.Length)
                    break;
                var sub = s.Substring(0, i);
                if (wordDict.Contains(sub))
                    BreakNextWords($"{candidate} {sub}", s.Substring(i), wordDict, res, minWordLen, maxWordLen);
            }
        }
    }

}