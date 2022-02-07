using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MinimumSumOfFourDigitNumberAfterSplittingDigits
{
    public class Solution
    {
        public int MinimumSum(int num)
        {
            var digits = new int[4];
            var s = num.ToString();
            for (int i = 0; i < 4; i++)
                digits[i] = (int)(s[i] - '0');
            Array.Sort(digits);
            return 10 * digits[0] + 10 * digits[1] + digits[2] + digits[3];
        }
    }
}