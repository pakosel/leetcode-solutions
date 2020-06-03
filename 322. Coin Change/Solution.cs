using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace CoinChange
{
    public class Solution
    {
        Dictionary<int, int> dictChange = new Dictionary<int, int>();

        public int CoinChange(int[] coins, int amount)
        {
            if (dictChange.ContainsKey(amount))
                return dictChange[amount];

            int res = -1;
            if (amount == 0)
                res = 0;
            else if (amount < 0)
                res = -1;
            else
                foreach (var coin in coins)
                {
                    if (coin > amount)
                        continue;

                    int change = CoinChange(coins, amount - coin);
                    if (change != -1 && (res == -1 || change + 1 < res))
                        res = change + 1;
                }

            dictChange.Add(amount, res);
            return res;
        }
    }
}