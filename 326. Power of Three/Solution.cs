using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace PowerOfThree
{
    public class Solution
    {
        public bool IsPowerOfThree(int n)
        {
            if (n <= 0)
                return false;

            while (n > 1)
            {
                if (n % 3 != 0)
                    return false;
                n /= 3;
            }

            return true;
        }
    }
}