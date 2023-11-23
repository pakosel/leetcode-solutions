using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace CountNicePairsInArray
{
    public class Solution
    {
        public int CountNicePairs(int[] nums)
        {
            const int MOD = 1_000_000_007;
            var sums = new Dictionary<int, int>();
            long res = 0;
            foreach (var n in nums)
            {
                var sum = Calc(n);
                if (!sums.ContainsKey(sum))
                    sums[sum] = 0;
                else
                {
                    res += sums[sum];
                    res %= MOD;
                }
                sums[sum]++;
            }
            return (int)res;

            int Calc(int n)
            {
                var rev = int.Parse(string.Join("", n.ToString().Reverse()));
                return n - rev;
            }
        }
    }
}