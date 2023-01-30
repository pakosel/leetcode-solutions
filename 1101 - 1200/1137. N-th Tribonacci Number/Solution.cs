using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace NthTribonacciNumber
{
    public class Solution
    {
        public int Tribonacci(int n)
        {
            if (n < 2)
                return n;
            (int n1, int n2, int n3) fibo = (0, 1, 1);
            for (int i = 3; i <= n; i++)
                (fibo.n1, fibo.n2, fibo.n3) = (fibo.n2, fibo.n3, fibo.n1 + fibo.n2 + fibo.n3);
            return fibo.n3;
        }
    }
}