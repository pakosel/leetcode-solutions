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
            var dict = arr.GroupBy(_ => _).ToDictionary(grp => grp.Key, grp => grp.Count());

            return dict.Count == dict.Values.Distinct().Count();
        }
    }
}