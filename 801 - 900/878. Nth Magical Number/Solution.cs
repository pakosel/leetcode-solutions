using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace NthMagicalNumber
{
    public class Solution
    {
        const int mod = 1_000_000_007;

        public int NthMagicalNumber(int n, int a, int b)
        {
            long A = a;
            long B = b;

            while (n-- > 1)
            {
                if (A == B)
                    n++;
                if (A < B)
                    A += a;
                else
                    B += b;
            }
            return (int)(Math.Min(A, B) % mod);
        }
    }
}