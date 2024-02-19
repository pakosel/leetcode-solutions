using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace PowerOfTwo
{
    public class Solution2024
    {
        public bool IsPowerOfTwo(int n)
        {
            var pow2 = new List<int>();
            for (int i = 0; i < 31; i++)
                pow2.Add(1 << i);
            return pow2.Contains(n);
        }
    }
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