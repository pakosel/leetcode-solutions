using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace CoinChange
{
    public class Solution_DP
    {
        public int CoinChange(int[] coins, int amount)
        {
            Array.Sort(coins, (x, y) => y.CompareTo(x));
            var cl = coins.Length;
            var dp = Enumerable.Range(0, cl).Select(_ => new int[amount + 1]).ToArray();

            for (int i = 0; i < cl; i++)
                dp[i][0] = 0;

            for (int i = 0; i < cl; i++)
                for (int j = 1; j <= amount; j++)
                {
                    dp[i][j] = (coins[i] > j || dp[i][j - coins[i]] == int.MaxValue ? int.MaxValue : 1 + dp[i][j - coins[i]]);
                    if (i > 0)
                        dp[i][j] = Math.Min(dp[i][j], dp[i - 1][j]);
                }
            return dp[cl - 1][amount] == int.MaxValue ? -1 : dp[cl - 1][amount];
        }
    }

    public class Solution_Recursive
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