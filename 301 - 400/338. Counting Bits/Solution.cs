using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace CountingBits
{
    public class Solution
    {
        public int[] CountBits(int n)
        {
            var res = new int[n + 1];
            var p = 2;
            for (int i = 1; i <= n; i++)
                if (p == i)
                {
                    res[i] = 1;
                    p *= 2;
                }
                else if (i % 2 == 1)
                    res[i] = res[i - 1] + 1;
                else
                    res[i] = Count(i);
            return res;
        }

        private int Count(int i)
        {
            var res = 0;
            while (i > 0)
            {
                res += (i % 2);
                i >>= 1;
            }
            return res;
        }
    }

}