using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ImplementMagicDictionary
{
    public class MagicDictionary
    {

        List<string> Dict;

        /** Initialize your data structure here. */
        public MagicDictionary()
        {
            Dict = new List<string>();
        }

        /** Build a dictionary through a list of words */
        public void BuildDict(string[] dict)
        {
            foreach (var word in dict)
                Dict.Add(word);
        }

        /** Returns if there is any word in the trie that equals to the given word after modifying exactly one character */
        public bool Search(string word)
        {
            var wordsToCheck = Dict.Where(w => w.Length == word.Length);
            foreach (var w in wordsToCheck)
                if (Matches(word, w))
                    return true;
            return false;
        }

        private bool Matches(string word1, string word2)
        {
            if (word1.Length != word2.Length)
                return false;
            int mismatch = 0;

            for (int i = 0; i < word1.Length; i++)
                if (word1[i] != word2[i])
                    if (mismatch == 0)
                        mismatch++;
                    else
                        return false;

            return mismatch == 1;
        }
    }
}