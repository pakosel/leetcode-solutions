using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace WordBreakII
{
    public class Solution2024
    {
        public IList<string> WordBreak(string s, IList<string> wordDict)
        {
            var trie = new Trie();
            foreach (var word in wordDict)
                TrieAdd(word, trie, 0);
            var res = new List<string>();

            Track(0, 0, trie, "");

            return res;

            void TrieAdd(string word, Trie trie, int pos)
            {
                if (trie.child[word[pos] - 'a'] == null)
                    trie.child[word[pos] - 'a'] = new Trie();
                if (pos == word.Length - 1)
                    trie.child[word[pos] - 'a'].isWord = true;
                else
                    TrieAdd(word, trie.child[word[pos] - 'a'], pos + 1);
            }

            void Track(int startPos, int currPos, Trie currTrie, string currRes)
            {
                if (currPos == s.Length)
                {
                    if(startPos == currPos)
                        res.Add(currRes[1..]);
                    return;
                }

                var c = s[currPos];
                if (currTrie.child[c - 'a'] == null)
                    return;

                if (currTrie.child[c - 'a'].isWord)
                {
                    Track(currPos + 1, currPos + 1, trie, $"{currRes} {s[startPos..(currPos+1)]}");
                }
                Track(startPos, currPos + 1, currTrie.child[c - 'a'], currRes);
            }
        }

        public class Trie
        {
            public Trie[] child = new Trie[26];
            public bool isWord;
        }
    }
    public class Solution
    {
        Dictionary<string, List<string>> cache = new Dictionary<string, List<string>>();
        IList<string> wordDict;
        int minWordLen;
        int maxWordLen;

        public IList<string> WordBreak(string s, IList<string> wordDict)
        {
            foreach (var c in s)
                if (!wordDict.Any(w => w.Contains(c)))
                    return new List<string>();

            this.wordDict = wordDict;
            maxWordLen = wordDict.Max(w => w.Length);
            minWordLen = wordDict.Min(w => w.Length);

            return BreakNextWords(s);
        }

        private IList<string> BreakNextWords(string s)
        {
            if (string.IsNullOrEmpty(s))
                return new List<string>();

            if (cache.ContainsKey(s))
                return cache[s];

            var list = new List<string>();

            for (int i = minWordLen; i <= maxWordLen; i++)
            {
                if (i > s.Length)
                    break;
                var subLeft = s.Substring(0, i);
                if (wordDict.Contains(subLeft))
                {
                    var subRight = s.Substring(i);
                    if (subRight.Length == 0)
                        list.Add($"{subLeft}");
                    else
                    {
                        var rest = BreakNextWords(subRight);
                        if (rest.Count == 0)
                            continue;  //no combination for the given subRight
                        foreach (var el in rest)
                            list.Add($"{subLeft} {el}");
                    }
                }
            }
            cache.Add(s, list);
            return list;
        }
    }
}