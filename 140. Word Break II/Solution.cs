using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace WordBreakII
{
    public class Solution
    {
        private Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        public IList<string> WordBreak(string s, IList<string> wordDict)
        {
            foreach (var c in s)
                if (!wordDict.Any(w => w.Contains(c)))
                    return new List<string>();

            var maxWordLen = wordDict.Max(w => w.Length);
            var minWordLen = wordDict.Min(w => w.Length);

            return BreakNextWords(s, wordDict, minWordLen, maxWordLen);
        }

        private IList<string> BreakNextWords(string s, IList<string> wordDict, int minWordLen, int maxWordLen)
        {
            if (string.IsNullOrEmpty(s))
                return new List<string>();

            if (dict.ContainsKey(s))
                return dict[s];

            var list = new List<string>();

            for (int i = minWordLen; i <= maxWordLen; i++)
            {
                if (i > s.Length)
                    break;
                var sub = s.Substring(0, i);
                if (wordDict.Contains(sub))
                {
                    var restString = s.Substring(i);
                    if (restString.Length == 0)
                        list.Add($"{sub}");
                    else
                    {
                        var rest = BreakNextWords(restString, wordDict, minWordLen, maxWordLen);
                        if (rest.Count == 0)
                            continue;
                        foreach (var el in rest)
                            list.Add($"{sub} {el}");
                    }
                }
            }
            dict.Add(s, list);

            return list;
        }
    }
}