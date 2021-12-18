using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace NumbersAtMostNGivenDigitSet
{
    public class Solution
    {
        //introducing expected output length parameter. If value != -1 we count the numbers of this length only
        public int AtMostNGivenDigitSet(string[] digits, int n, int expLen = -1)
        {
            var res = 0;
            if (n < 10 && expLen < 2)
            {
                for (int i = 0; i < digits.Length; i++)
                    if (digits[i][0] - '0' <= n)
                        res++;
            }
            else
            {
                var s = n.ToString();
                var len = s.Length;
                if (expLen != -1 && len != expLen)
                    return 0;

                int first = s[0] - '0';
                for (int i = 0; i < digits.Length; i++)
                {
                    int digit = digits[i][0] - '0';

                    if (digit < first)  //all digits can be used on all positions
                        res += (int)Math.Pow(digits.Length, len - 1);
                    else if (digit == first)   //this digit can be used on first position - count number of combinations of EXACT (len-1) length
                        res += AtMostNGivenDigitSet(digits, n % (int)Math.Pow(10, len - 1), len - 1);
                }
                if (expLen == -1)   //add all combinations of at most len-1 length
                    for (int i = len - 1; i > 0; i--)
                        res += (int)Math.Pow(digits.Length, i);
            }
            return res;
        }
    }
}