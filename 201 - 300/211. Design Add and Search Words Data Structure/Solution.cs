using System.Collections.Generic;
using System.Linq;
using System;
using System.Text.RegularExpressions;
using Common;

namespace DesignAddAndSearchWordsDataStructure
{
    public class WordDictionary_2023
    {
        Trie trie;

        public WordDictionary_2023()
        {
            trie = new Trie();
        }

        public void AddWord(string word)
        {
            var t = trie;
            foreach (var c in word)
            {
                var i = c - 'a';
                if (t.Children[i] == null)
                    t.Children[i] = new Trie();
                t = t.Children[i];
            }
            t.IsFinal = true;
        }

        public bool Search(string word)
        {
            return Dfs(word, trie, 0);
        }

        private bool Dfs(string word, Trie t, int pos)
        {
            if (word[pos] == '.')
            {
                if (pos == word.Length - 1)
                    return t.Children.Any(c => c?.IsFinal ?? false);
                else
                {
                    foreach (var tt in t.Children.Where(c => c != null))
                        if (Dfs(word, tt, pos + 1))
                            return true;
                    return false;
                }
            }
            else
            {
                var i = word[pos] - 'a';
                if (pos == word.Length - 1)
                    return t.Children[i]?.IsFinal ?? false;
                else if (t.Children[i] != null)
                    return Dfs(word, t.Children[i], pos + 1);
            }

            return false;
        }
    }
    public class WordDictionary
    {
        Dictionary<int, HashSet<string>> dict;

        public WordDictionary()
        {
            dict = new Dictionary<int, HashSet<string>>();
        }

        public void AddWord(string word)
        {
            var len = word.Length;
            if (!dict.ContainsKey(len))
                dict.Add(len, new HashSet<string>());
            dict[len].Add(word);
        }

        public bool Search(string word)
        {
            var len = word.Length;
            if (!dict.ContainsKey(len))
                return false;
            var regex = new Regex(word.Replace(".", "[a-z]"));
            return dict[len].Any(w => regex.IsMatch(w));
        }
    }
}