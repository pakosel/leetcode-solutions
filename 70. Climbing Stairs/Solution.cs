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

            int[] res = new int[n];
            res[n - 1] = 1;
            res[n - 2] = 2;
            for (int i = n - 3; i >= 0; i--)
                res[i] = res[i + 1] + res[i + 2];

            return res[0];
        }
    }
}