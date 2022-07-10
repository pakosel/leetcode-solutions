using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace FibonacciNumber
{
    public class Solution
    {
        public int Fib(int n)
        {
            if (n < 2)
                return n;
            var n1 = 1;
            var n2 = 0;
            while (n-- >= 2)
                (n1, n2) = (n1 + n2, n1);
            return n1;
        }
    }
}