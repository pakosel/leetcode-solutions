using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ShortEncodingOfWords
{
    public class Solution_Trie
    {
        public int MinimumLengthEncoding(string[] words)
        {
            Array.Sort(words, (x, y) => y.Length.CompareTo(x.Length));
            var trie = new Trie();
            var res = 0;

            foreach(var w in words)
            {
                var t = trie;
                var counts = false;
                for(int i=w.Length-1; i>=0; i--)
                {
                    if(t.Children[w[i]-'a'] == null)
                    {
                        t.Children[w[i]-'a'] = new Trie();
                        counts = true;
                    }
                    t = t.Children[w[i]-'a'];
                }
                if(counts)
                    res += w.Length + 1;
            }

            return res;
        }

        public class Trie
        {
            public Trie[] Children;

            public Trie()
            {
                Children = new Trie[26];
            }
        }
    }

    public class Solution
    {
        public int MinimumLengthEncoding(string[] words)
        {
            var hSet = new HashSet<string>();
            Array.Sort(words, (x, y) => y.Length.CompareTo(x.Length));

            foreach (var w in words)
                if (!hSet.Any(e => w == e.Substring(e.Length - w.Length, w.Length)))
                    hSet.Add(w);

            return hSet.Sum(e => e.Length) + hSet.Count();
        }
    }
}