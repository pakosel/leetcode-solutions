using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MaximumValueOfKCoinsFromPiles
{
    public class Solution
    {
        public int MaxValueOfCoins(IList<IList<int>> piles, int k)
        {
            var memo = new int[piles.Count + 1, k + 1];

            return Max(0, k);

            int Max(int start, int k)
            {
                if (start == piles.Count - 1)
                    return piles[start].Take(Math.Min(piles[start].Count, k)).Sum();

                if (memo[start, k] != 0)
                    return memo[start, k];

                var res = Max(start + 1, k);
                var sum = 0;
                for (int i = 0; i < k && i < piles[start].Count; i++)
                {
                    sum += piles[start][i];
                    res = Math.Max(res, sum + Max(start + 1, k - i - 1));
                }

                memo[start, k] = res;
                return res;
            }
        }
    }
}