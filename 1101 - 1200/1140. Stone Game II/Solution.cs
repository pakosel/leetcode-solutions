using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace StoneGameII
{
    public class Solution
    {
        public int StoneGameII(int[] piles)
        {
            var memo = new Dictionary<(int i, int m), (int, int)>();

            return Memo(0, 1).a;

            (int a, int b) Memo(int i, int m)
            {
                if (i >= piles.Length)
                    return (0, 0);
                if (memo.ContainsKey((i, m)))
                    return memo[(i, m)];
                (int a, int b) res = (0, 0);
                var sum = 0;
                for (int x = 0; x < 2 * m && i + x < piles.Length; x++)
                {
                    sum += piles[i + x];
                    var next = Memo(i + x + 1, Math.Max(m, x + 1));
                    if (sum + next.b > res.a)
                        res = (sum + next.b, next.a);
                }
                memo.Add((i, m), res);

                return res;
            }
        }
    }
}