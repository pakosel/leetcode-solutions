using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace CoinChangeII
{
    public class Solution
    {
        public int Change(int amount, int[] coins)
        {
            var len = coins.Length;
            Array.Sort(coins, (c1, c2) => c1.CompareTo(c2));

            var dp = new int[len + 1, amount + 1];
            for (int i = 1; i <= len; i++)
                dp[i, 0] = 1;

            for (int ci = 0; ci < len; ci++)
                for (int a = 1; a <= amount; a++)
                    if (coins[ci] > a)
                        dp[ci + 1, a] = dp[ci, a];
                    else
                        dp[ci + 1, a] = dp[ci, a] + dp[ci + 1, a - coins[ci]];

            return dp[len, amount];
        }
    }
}