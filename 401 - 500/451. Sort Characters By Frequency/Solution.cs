using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace SortCharactersByFrequency
{
    public class Solution
    {
        public string FrequencySort(string s)
        {
            var dict = s.GroupBy(_ => _).ToDictionary(grp => grp.Key, grp => grp.Count());
            var res = new StringBuilder();

            foreach (var kvp in dict.OrderByDescending(kvp => kvp.Value))
                for (int i = 0; i < kvp.Value; i++)
                    res.Append(kvp.Key);

            return res.ToString();
        }
    }
}