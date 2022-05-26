using System.Collections.Generic;
using System.Linq;
using System;
using Common;

namespace NumberOf1Bits
{
    public class Solution
    {
        public int HammingWeight(uint n)
        {
            var res = 0;
            while (n > 0)
            {
                res += (int)(n & 1);
                n >>= 1;
            }
            return res;
        }
    }
}