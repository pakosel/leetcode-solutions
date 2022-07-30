using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace WordSubsets
{
    public class Solution
    {
        public IList<string> WordSubsets(string[] words1, string[] words2)
        {
            var res = new List<string>();
            var maxLetCnt = new int[26];
            foreach (var word in words2.Distinct())
            {
                var arr = BuildArr(word);
                for (int i = 0; i < 26; i++)
                    maxLetCnt[i] = Math.Max(maxLetCnt[i], arr[i]);
            }

            foreach (var word in words1)
            {
                var arr = BuildArr(word);
                int i = 0;
                for (i = 0; i < 26; i++)
                    if (arr[i] < maxLetCnt[i])
                        break;
                if (i == 26)
                    res.Add(word);

            }
            return res;

            int[] BuildArr(string word)
            {
                var arr = new int[26];
                foreach (var c in word)
                    arr[c - 'a']++;
                return arr;
            }
        }
    }

    public class Solution_TLE
    {
        public IList<string> WordSubsets(string[] words1, string[] words2)
        {
            var res = new List<string>();
            var grpWords1 = words1.ToDictionary(x => x, x => x.GroupBy(_ => _).ToDictionary(x => x.Key, x => x.Count()));
            var grpWords2 = words2.Distinct().ToDictionary(x => x, x => x.GroupBy(_ => _).ToDictionary(x => x.Key, x => x.Count()));

            foreach (var word in words1)
                if (IsUniversal(word))
                    res.Add(word);
            return res;

            bool IsUniversal(string word)
            {
                foreach (var w in grpWords2.Keys)
                    if (!IsSubset(w, word))
                        return false;
                return true;
            }

            bool IsSubset(string w, string word)
            {
                foreach (var c in grpWords2[w])
                    if (!grpWords1[word].ContainsKey(c.Key) || grpWords1[word][c.Key] < c.Value)
                        return false;
                return true;
            }
        }
    }
}