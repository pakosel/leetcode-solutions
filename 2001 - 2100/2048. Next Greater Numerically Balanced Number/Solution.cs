using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace NextGreaterNumericallyBalancedNumber
{
    public class Solution
    {
        public int NextBeautifulNumber(int n)
        {
            for (int i = n + 1; i < 10_000_000; i++)
                if (IsBeauty(i))
                    return i;
            return -1;
        }

        private bool IsBeauty(int n)
        {
            var digits = new int[10];
            while (n > 0)
            {
                var mod = n % 10;
                if (mod == 0)
                    return false;
                digits[mod]++;
                n /= 10;
            }

            for (int j = 1; j < 10; j++)
                if (digits[j] != 0 && digits[j] != j)
                    return false;

            return true;
        }
    }
}