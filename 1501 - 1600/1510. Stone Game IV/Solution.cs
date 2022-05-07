using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace StoneGameIV
{
    public class Solution
    {
        Dictionary<int, bool> memo = new Dictionary<int, bool>();

        public bool WinnerSquareGame(int n)
        {
            memo.Add(0, false);
            memo.Add(1, true);
            memo.Add(2, false);

            return Winner(n);
        }

        private bool Winner(int n)
        {
            if (memo.ContainsKey(n))
                return memo[n];

            var res = false;
            var sqrt = (int)Math.Sqrt(n);
            for (int i = sqrt; i > 0 && !res; i--)
                res |= !Winner(n - i * i);

            memo.Add(n, res);
            return res;
        }
    }

}