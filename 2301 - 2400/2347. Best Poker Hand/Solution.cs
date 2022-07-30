using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace BestPokerHand
{
    public class Solution
    {
        public string BestHand(int[] ranks, char[] suits)
        {
            if (suits.All(s => s == suits.First()))
                return "Flush";
            var grp = ranks.GroupBy(_ => _).ToDictionary(x => x.Key, x => x.Count()).OrderByDescending(kvp => kvp.Value);
            if (grp.First().Value > 2)
                return "Three of a Kind";
            else if (grp.First().Value > 1)
                return "Pair";
            else
                return "High Card";
        }
    }
}