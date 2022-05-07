using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ComplementOfBase10Integer
{
    public class Solution
    {
        public int BitwiseComplement(int n)
        {
            if (n == 0)
                return 1;
            var len = (int)Math.Log2(n) + 1;
            var xor = (int)Math.Pow(2, len) - 1;

            return n ^ xor;
        }
    }
}