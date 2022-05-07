using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace NthDigit
{
    public class Solution
    {
        public int FindNthDigit(int n)
        {
            if (n == 0)
                return 0;
            if (n == int.MaxValue)
                return 2;

            int baseLen = 0;
            int i = 1;
            int currLen = 0;
            int mod = 1;
            while (true)
            {
                if (i % mod == 0)
                {
                    mod *= 10;
                    currLen++;
                }

                if (baseLen + currLen >= n)
                    break;
                baseLen += currLen;
                i++;
            }

            return i.ToString()[n - baseLen - 1] - '0';
        }
    }
}