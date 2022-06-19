using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace SearchSuggestionsSystem
{
    public class Solution
    {
        public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {
            Array.Sort(products);
            var Trie = new Trie();
            //add all products to Trie
            for (int x = 0; x < products.Length; x++)
            {
                var trie = Trie;
                var p = products[x];
                for (int i = 0; i < p.Length; i++)
                {
                    if (trie.Children[p[i] - 'a'] == null)
                        trie.Children[p[i] - 'a'] = new Trie();
                    trie = trie.Children[p[i] - 'a'];
                    trie.Indexes.Add(x);
                }
            }
            
            var res = new IList<string>[searchWord.Length];
            for (int i = 0; i < searchWord.Length; i++)
                if (Trie != null)
                {
                    var letter = searchWord[i] - 'a';
                    var cnt = (Trie.Children[letter] != null ? Trie.Children[letter].Indexes.Count : 0);
                    cnt = Math.Min(3, cnt);
                    res[i] = new List<string>(cnt);
                    for (int j = 0; j < cnt; j++)
                        res[i].Add(products[Trie.Children[letter].Indexes[j]]);
                    Trie = Trie.Children[letter];
                }
                else
                    res[i] = new string[0];

            return res;
        }

        public class Trie
        {
            public Trie[] Children;
            public List<int> Indexes;

            public Trie()
            {
                Children = new Trie[26];
                Indexes = new List<int>();
            }
        }
    }
}