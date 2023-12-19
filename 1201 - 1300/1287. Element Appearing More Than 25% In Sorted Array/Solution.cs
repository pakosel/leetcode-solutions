using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ElementAppearingMoreThan25InSortedArray
{
    public class Solution
    {
        public int FindSpecialInteger(int[] arr)
        {
            return arr.GroupBy(_ => _).Select(g => new { g.Key, Count = g.Count() }).OrderByDescending(p => p.Count).First().Key;
        }
    }
}