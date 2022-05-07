using System.Collections.Generic;
using System.Linq;
using System;
using System.Text.RegularExpressions;

namespace DesignAddAndSearchWordsDataStructure
{
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