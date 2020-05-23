using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ClimbingStairs
{
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
    }
}