using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace DetermineIfTwoStringsAreClose
{
    public class Solution
    {
        public bool CloseStrings(string word1, string word2)
        {
            if (word1.Length != word2.Length)
                return false;
            var dict1 = word1.GroupBy(_ => _).ToDictionary(grp => grp.Key, grp => grp.Count());
            var dict2 = word2.GroupBy(_ => _).ToDictionary(grp => grp.Key, grp => grp.Count());

            if (dict1.Keys.Any(k => !dict2.Keys.Contains(k)))
                return false;

            var cnt1 = dict1.OrderBy(kvp => kvp.Value).Select(kvp => kvp.Value);
            var cnt2 = dict2.OrderBy(kvp => kvp.Value).Select(kvp => kvp.Value);

            return cnt1.SequenceEqual(cnt2);
        }
    }
}