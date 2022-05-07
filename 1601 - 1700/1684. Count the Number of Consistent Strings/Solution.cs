using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace CountNumberConsistentStrings
{
    public class Solution
    {
        public int CountConsistentStrings(string allowed, string[] words)
        {
            bool[] letters = new bool[26];
            foreach (var l in allowed)
                letters[l - 'a'] = true;

            return words.Count(w => w.All(c => letters[c - 'a']));
        }
    }
}