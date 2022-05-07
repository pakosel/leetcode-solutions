using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace PowerOfTwo
{
    public class Solution
    {
        public bool IsPowerOfTwo(int n)
        {
            var hadOne = false;
            while (n != 0)
            {
                var one = (n & 1) == 1;
                if (one)
                    if (hadOne)
                        return false;
                    else
                        hadOne = true;
                n >>= 1;
            }
            return hadOne;
        }
    }
}