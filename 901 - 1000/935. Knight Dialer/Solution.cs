using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace KnightDialer
{
    public class Solution
    {
        public int KnightDialer(int n)
        {
            const int MOD = 1_000_000_007;
            var jump = new int[][] { new int[]{4, 6}, new int[] {6, 8}, new int[] {7, 9},
                                     new int[]{4, 8}, new int[] {0, 3, 9}, new int[]{}, new int[]{0, 1, 7},
                                     new int[]{2, 6}, new int[]{1, 3}, new int[]{2, 4}};
            var dict = new Dictionary<(int d, int c), int>();

            var res = 0;
            for (int i = 0; i < 10; i++)
            {
                res += Calc(i, n);
                res %= MOD;
            }
            return res;

            int Calc(int d, int len)
            {
                if (len == 1)
                    return 1;

                if (dict.ContainsKey((d, len)))
                    return dict[(d, len)];

                var res = 0;
                foreach (var next in jump[d])
                {
                    res += Calc(next, len - 1);
                    res %= MOD;
                }
                dict[(d, len)] = res;
                return res;
            }
        }
    }
}