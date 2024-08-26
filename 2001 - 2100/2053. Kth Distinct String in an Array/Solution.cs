using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace KthDistinctStringInAnArray
{
    public class Solution
    {
        public string KthDistinct(string[] arr, int k)
        {
            var dict = arr.GroupBy(_ => _).Where(grp => grp.Count() == 1).ToDictionary(grp => grp.Key, grp => grp.Count());

            foreach (var s in arr)
                if (dict.ContainsKey(s) && --k == 0)
                    return s;

            return string.Empty;
        }
    }
}