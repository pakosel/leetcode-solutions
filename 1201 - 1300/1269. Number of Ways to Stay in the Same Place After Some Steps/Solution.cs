using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace NumberOfWaysToStayInTheSamePlaceAfterSomeSteps
{
    public class Solution
    {
        const int MOD = 1_000_000_007;
        public int NumWays(int steps, int arrLen)
        {
            var memo = new Dictionary<(int pos, int steps), long>();

            return (int)(Memo(0, steps) % MOD);

            long Memo(int pos, int stepsLeft)
            {
                if (pos < 0 || pos >= arrLen)
                    return 0;
                if (stepsLeft == 0)
                    return pos == 0 ? 1 : 0;

                var key = (pos, stepsLeft);
                if (memo.ContainsKey(key))
                    return memo[key];
                memo[key] = (Memo(pos - 1, stepsLeft - 1) + Memo(pos + 1, stepsLeft - 1) + Memo(pos, stepsLeft - 1)) % MOD;

                return memo[key];
            }
        }
    }
}