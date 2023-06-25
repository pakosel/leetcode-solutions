using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace CountAllPossibleRoutes
{
    public class Solution
    {
        public int CountRoutes(int[] locations, int start, int finish, int fuel)
        {
            const int MOD = 1_000_000_007;
            var memo = new Dictionary<(int p, int f), int>();
            return Memo(start, fuel);

            int Memo(int point, int remFuel)
            {
                var key = (point, remFuel);
                if (memo.ContainsKey(key))
                    return memo[key];
                long res = point == finish ? 1 : 0;
                for (int i = 0; i < locations.Length; i++)
                    if (point != i && Math.Abs(locations[point] - locations[i]) <= remFuel)
                        res += Memo(i, remFuel - Math.Abs(locations[point] - locations[i]));

                res %= MOD;

                memo[key] = (int)res;
                return memo[key];
            }
        }
    }

}