using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ConcatenationOfConsecutiveBinaryNumbers
{
    public class Solution
    {
        public int ConcatenatedBinary(int n)
        {
            var MOD = 1_000_000_007;
            long res = 0;
            var q = new Stack<int>();
            for (int i = 1; i <= n; i++)
            {
                var x = i;
                while (x > 0)
                {
                    q.Push(x & 1);
                    x >>= 1;
                }
                while (q.Count > 0)
                {
                    res <<= 1;
                    res += q.Pop();
                }
                if (res >= MOD)
                    res %= MOD;
            }
            return (int)(res % MOD);
        }
    }
}