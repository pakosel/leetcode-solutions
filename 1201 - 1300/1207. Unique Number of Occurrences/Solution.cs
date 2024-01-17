using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace UniqueNumberOfOccurrences
{
    public class Solution
    {
        public bool UniqueOccurrences(int[] arr)
        {
            var allCounts = arr.GroupBy(_ => _).ToDictionary(grp => grp.Key, grp => grp.Count()).Select(kvp => kvp.Value);
            return allCounts.Count() == allCounts.Distinct().Count();
        }
    }
}