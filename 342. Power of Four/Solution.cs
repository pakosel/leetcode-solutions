using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace PowerOfFour
{
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