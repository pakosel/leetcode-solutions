using System.Collections.Generic;
using System.Linq;
using System;
using System.Text.RegularExpressions;
using Common;

namespace ImplementTriePrefixTree
{
    public class Trie
    {
        Common.Trie trie;

        public Trie()
        {
            trie = new Common.Trie();
        }

        public void Insert(string word)
        {
            var t = trie;
            foreach (var c in word)
            {
                var i = c - 'a';
                if (t.Children[i] == null)
                    t.Children[i] = new Common.Trie();
                t = t.Children[i];
            }
            t.IsFinal = true;
        }

        public bool Search(string word)
        {
            return Get(word)?.IsFinal ?? false;
        }

        public bool StartsWith(string prefix)
        {
            return Get(prefix) != null;
        }

        private Common.Trie Get(string prefix)
        {
            var t = trie;
            foreach (var c in prefix)
                if (t.Children[c - 'a'] == null)
                    return null;
                else
                    t = t.Children[c - 'a'];
            return t;
        }
    }
}