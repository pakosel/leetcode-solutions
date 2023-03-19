using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Common
{
    public class Trie
    {
        public Trie[] Children;
        public bool IsFinal;

        public Trie()
        {
            Children = new Trie[26];
        }
    }
}