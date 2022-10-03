using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace NumberOfDiceRollsWithTargetSum
{
    public class Solution
    {
        Dictionary<(int n, int t), int> memo = new();
        int MOD = 1_000_000_007;

        public int NumRollsToTarget(int n, int k, int target)
        {
            if (n == 1)
                return target <= k ? 1 : 0;
            if (memo.ContainsKey((n, target)))
                return memo[(n, target)];
            long res = 0;
            for (int i = 1; i <= k && i < target; i++)
            {
                res += NumRollsToTarget(n - 1, k, target - i);
                res %= MOD;
            }
            memo.Add((n, target), (int)res);

            return (int)res;
        }
    }
}