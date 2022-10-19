using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace TopKFrequentWords
{
    public class Solution
    {
        public IList<string> TopKFrequent(string[] words, int k)
        {
            var dict = new Dictionary<string, int>();
            foreach (var w in words)
                if (dict.ContainsKey(w))
                    dict[w]++;
                else
                    dict.Add(w, 1);
            return dict.OrderByDescending(kvp => kvp.Value).ThenBy(kvp => kvp.Key).Select(kvp => kvp.Key).Take(k).ToList();
        }
    }
}