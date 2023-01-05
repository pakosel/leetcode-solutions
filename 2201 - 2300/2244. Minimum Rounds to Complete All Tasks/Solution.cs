using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MinimumRoundsToCompleteAllTasks
{
    public class Solution
    {
        public int MinimumRounds(int[] tasks)
        {
            var memo = new Dictionary<int, int>();
            memo.Add(0, 0);
            var grp = tasks.GroupBy(_ => _).ToDictionary(g => g.Key, g => g.Count());
            var res = 0;
            foreach (var c in grp.Values)
                if (c == 1)
                    return -1;
                else
                    res += Factorize(c);

            return res;

            int Factorize(int n)
            {
                if (n < 0 || n == 1)
                    return int.MaxValue;

                if (memo.ContainsKey(n))
                    return memo[n];
                var res = 1 + Math.Min(Factorize(n - 2), Factorize(n - 3));
                memo.Add(n, res);
                return res;
            }
        }
    }
}