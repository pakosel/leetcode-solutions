using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace PowerOfFour
{
    public class Solution_2022
    {
        public bool IsPowerOfFour(int n)
        {
            var zeros = 0;
            while (n > 0 && (n & 1) == 0)
            {
                zeros++;
                n >>= 1;
            }
            if (zeros % 2 == 0 && n == 1)
                return true;
            return false;
        }
    }
    
    public class Solution
    {
        public bool IsPowerOfFour(int n)
        {
            if (n < 0)
                return false;

            long f = 1;
            while (f < int.MaxValue)
            {
                if (n == f)
                    return true;
                f *= 4;
            }
            return false;
        }
    }
}