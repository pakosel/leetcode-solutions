using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace FindPlayersWithZeroOrOneLosses
{
    public class Solution_2024
    {
        public IList<IList<int>> FindWinners(int[][] matches)
        {
            var winners = matches.GroupBy(m => m[0]).ToDictionary(grp => grp.Key, grp => grp.Count());
            var loosers = matches.GroupBy(m => m[1]).ToDictionary(grp => grp.Key, grp => grp.Count());

            return new IList<int>[] {
            winners.Where(w => !loosers.ContainsKey(w.Key)).Select(w => w.Key).OrderBy(_ => _).ToList(),
            loosers.Where(l => l.Value == 1).Select(l => l.Key).OrderBy(_ => _).ToList()
        };
        }
    }
    
    public class Solution
    {
        public IList<IList<int>> FindWinners(int[][] matches)
        {
            var dict = new Dictionary<int, int>();
            foreach (var match in matches)
            {
                if (!dict.ContainsKey(match[0]))
                    dict.Add(match[0], 0);
                if (!dict.ContainsKey(match[1]))
                    dict.Add(match[1], 1);
                else
                    dict[match[1]]++;
            }

            var res = new IList<int>[] { new List<int>(), new List<int>() };
            foreach (var kvp in dict.OrderBy(kvp => kvp.Key))
                if (kvp.Value == 0)
                    res[0].Add(kvp.Key);
                else if (kvp.Value == 1)
                    res[1].Add(kvp.Key);

            return res;
        }
    }
}