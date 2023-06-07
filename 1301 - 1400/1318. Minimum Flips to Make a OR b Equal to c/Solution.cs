using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MinimumFlips
{
    public class Solution
    {
        public int MinFlips(int a, int b, int c)
        {
            var res = 0;
            while (a > 0 || b > 0 || c > 0)
            {
                var ax = a & 1;
                var bx = b & 1;
                if ((c & 1) == 0)
                {
                    res += ax;
                    res += bx;
                }
                else if (ax == 0 && bx == 0)
                    res++;
                a >>= 1;
                b >>= 1;
                c >>= 1;
            }
            return res;
        }
    }
}