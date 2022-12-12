using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ClimbingStairs
{
    public class Solution_2022
    {
        public int ClimbStairs(int n)
        {
            if (n < 3)
                return n;
            var prev1 = 2;
            var prev2 = 1;
            for (int i = 3; i <= n; i++)
                (prev2, prev1) = (prev1, prev1 + prev2);
            return prev1;
        }
    }

    public class Solution
    {
        public int ClimbStairs(int n)
        {
            if (n < 3)
                return n;

            int n_2 = 2;
            int n_1 = 1;
            int res = 0;

            int i = 3;
            while (i++ <= n)
            {
                res = n_2 + n_1;
                n_1 = n_2;
                n_2 = res;
            }

            return res;
        }

        public int ClimbStairs_DP(int n)
        {
            if (n < 3)
                return n;

            int[] res = new int[n];
            res[n - 1] = 1;
            res[n - 2] = 2;
            for (int i = n - 3; i >= 0; i--)
                res[i] = res[i + 1] + res[i + 2];

            return res[0];
        }

    }
}