using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace PalindromePairs
{
    public class Solution
    {
        public IList<IList<int>> PalindromePairs(string[] words)
        {
            var res = new List<IList<int>>();
            var root = new Trie();
            List<int> allPalindromes = null;
            var memo = new Dictionary<(int, int, int), bool>();

            //put all words into Trie
            for (int i = 0; i < words.Length; i++)
            {
                var word = words[i];
                var trie = root;
                foreach (var c in word)
                {
                    if (trie.Letters[c - 'a'] == null)
                        trie.Letters[c - 'a'] = new Trie();
                    trie = trie.Letters[c - 'a'];
                    trie.WordIndices.Add(i);
                }
                trie.WordIndices.Remove(i);
                trie.FinalWords.Add(i);
            }

            //check each word backwars for possible match
            for (int i = 0; i < words.Length; i++)
            {
                var word = words[i];
                if (word.Length == 0)    //empty string - matches with all palindromes twice
                {
                    foreach (var idx in GetALlPalindromes())
                    {
                        res.Add(new int[] { idx, i });
                        res.Add(new int[] { i, idx });
                    }
                    continue;
                }

                var trie = root;
                int j = word.Length;
                while (--j >= 0)
                {
                    var c = word[j];
                    if (trie.Letters[c - 'a'] == null)
                        break;
                    trie = trie.Letters[c - 'a'];
                    if (trie.FinalWords.Count > 0 && CheckPalindrome(i, 0, j - 1))
                        foreach (var idx in trie.FinalWords)
                            if (idx != i)
                                res.Add(new int[] { idx, i });
                }
                if (j < 0)
                    foreach (var idx in trie.WordIndices)
                        if (CheckPalindrome(idx, word.Length, words[idx].Length - 1))
                            if (idx != i)
                                res.Add(new int[] { idx, i });
            }

            return res.ToList();

            bool CheckPalindrome(int i, int left, int right)
            {
                if (memo.ContainsKey((i, left, right)))
                    return memo[(i, left, right)];
                var res = true;
                string word = words[i];
                while (left < right)
                    if (word[left++] != word[right--])
                    {
                        res = false;
                        break;
                    }
                memo.Add((i, left, right), res);
                return res;
            }

            List<int> GetALlPalindromes()
            {
                if (allPalindromes == null)
                {
                    allPalindromes = new List<int>(words.Length);
                    for (int i = 0; i < words.Length; i++)
                        if (words[i].Length > 0 && CheckPalindrome(i, 0, words[i].Length - 1))
                            allPalindromes.Add(i);
                }
                return allPalindromes;
            }
        }

        public class Trie
        {
            public List<int> FinalWords = new List<int>();
            public List<int> WordIndices = new List<int>();
            public Trie[] Letters = new Trie[26];
        }
    }
}