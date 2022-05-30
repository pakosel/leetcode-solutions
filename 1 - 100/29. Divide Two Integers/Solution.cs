using System.Collections.Generic;
using System.Linq;
using System;

namespace DivideTwoIntegers
{
    public class Solution
    {
        public int Divide(int dividend, int divisor)
        {
            if (dividend == 0)
                return 0;
            var sign = ((dividend > 0 && divisor > 0) || (dividend < 0 && divisor < 0) ? 1 : -1);

            long dividendAbs = Math.Abs((long)dividend);
            long divisorAbs = Math.Abs((long)divisor);
            if (divisorAbs > dividendAbs)
                return 0;

            string str = dividendAbs.ToString();
            string resStr = "";
            int start = 0;
            long rem = 0;
            while (start < str.Length)
            {
                var end = start;
                while (end < str.Length)
                {
                    var tgt = long.Parse(rem + str.Substring(start, end - start + 1));
                    var quotient = DivideByAdding(tgt, divisorAbs);
                    resStr += quotient.res;
                    if (quotient.res > 0)
                    {
                        rem = quotient.rem;
                        break;
                    }
                    else
                        end++;
                }
                start = end + 1;
            }
            long res = long.Parse(resStr);

            if (sign < 0)
                res = 0 - res;

            if (res > int.MaxValue)
                return int.MaxValue;
            if (res < int.MinValue)
                return int.MinValue;

            return (int)res;

            (long res, long rem) DivideByAdding(long tgt, long div)
            {
                long val = 0;
                (long res, long rem) result = (0, 0);
                while (val + div <= tgt)
                {
                    val += div;
                    result.res++;
                }
                result.rem = tgt - val;
                return result;
            }
        }
    }
}