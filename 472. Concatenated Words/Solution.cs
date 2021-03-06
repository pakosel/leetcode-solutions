using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ConcatenatedWords
{
    public class Solution
    {
        Dictionary<string, bool> checkedWords = new Dictionary<string, bool>();
        int minWordLen;
        int maxWordLen;

        public IList<string> FindAllConcatenatedWordsInADict(string[] words)
        {
            var result = new List<string>();

            var wordsSet = new HashSet<string>(words.Where(w => w != string.Empty));
            if(wordsSet.Count == 0)
                return result;

            minWordLen = wordsSet.Min(w => w.Length);
            maxWordLen = wordsSet.Max(w => w.Length);

            foreach (var w in wordsSet)
                if (CheckWord(w, wordsSet))
                    result.Add(w);

            return result;
        }

        private bool CheckWord(string word, HashSet<string> words)
        {
            if (checkedWords.ContainsKey(word))
                return checkedWords[word];

            var sb = new StringBuilder();
            bool res = false;
            int i = 0;
            int len = word.Length;
            while (i < Math.Min(minWordLen, len))
                sb.Append(word[i++]);
            while (i < Math.Min(maxWordLen, len))
            {
                var leftWord = sb.ToString();
                if (words.Contains(leftWord))
                {
                    var rightWord = word.Substring(i);
                    if (words.Contains(rightWord) || CheckWord(rightWord, words))
                    {
                        res = true;
                        break;
                    }
                }
                sb.Append(word[i++]);
            }

            checkedWords.Add(word, res);
            return res;
        }
    }
}