using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace CountGoodMeals
{
    public class Solution
    {
        public int CountPairs(int[] deliciousness)
        {
            const int MOD = 1_000_000_007;
            List<int> pow = new List<int>();
            var temp = 1;
            for (int i = 0; i < 31; i++)
            {
                pow.Add(temp);
                temp <<= 1;
            }

            var res = 0;
            var dict = deliciousness.GroupBy(_ => _).ToDictionary(x => x.Key, x => x.Count());

            foreach (var d in deliciousness.OrderBy(_ => _))
            {
                foreach (var p in pow)
                    if (dict[d] > 0 && dict.ContainsKey(p - d) && dict[p - d] > 0)
                        if (p - d < d || (d == p - d && dict[d] < 2))
                            continue;
                        else
                        {
                            if (d == p - d)
                                dict[d]--;
                            res += dict[p - d];
                            res %= MOD;
                        }
            }
            return res;
        }

    }
}