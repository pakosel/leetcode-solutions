using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace OnesAndZeroes
{
    public class Solution
    {
        Dictionary<(int m, int n, int start), int> memo = new();
        public int FindMaxForm(string[] strs, int m, int n, int start = 0)
        {
            if (start == strs.Length)
                return 0;

            if (memo.ContainsKey((m, n, start)))
                return memo[(m, n, start)];

            var res = FindMaxForm(strs, m, n, start + 1);
            var cnt = Count(strs[start]);
            if (cnt.m <= m && cnt.n <= n)
                res = Math.Max(res, 1 + FindMaxForm(strs, m - cnt.m, n - cnt.n, start + 1));

            memo.Add((m, n, start), res);
            return res;

            (int m, int n) Count(string s)
            {
                (int m, int n) res = (0, 0);
                foreach (var c in s)
                    if (c == '0')
                        res.m++;
                    else
                        res.n++;
                return res;
            }
        }
    }

    public class Solution_DP
    {
        public int FindMaxForm(string[] strs, int m, int n, int start = 0)
        {
            var dp = Enumerable.Range(0, m + 1).Select(_ => new int[n + 1]).ToArray();

            foreach (var s in strs)
            {
                var cntZ = s.Count(c => c == '0');
                var cntO = s.Length - cntZ;

                for (int i = m; i >= cntZ; i--)
                    for (int j = n; j >= cntO; j--)
                        dp[i][j] = Math.Max(dp[i][j], 1 + dp[i - cntZ][j - cntO]);
            }

            return dp[m][n];
        }
    }
}