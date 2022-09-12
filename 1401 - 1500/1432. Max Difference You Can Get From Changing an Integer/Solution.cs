using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MaxDifferenceYouCanGetFromChangingInteger
{
    public class Solution
    {
        public int MaxDiff(int num)
        {
            var numStr = num.ToString();
            var firstDigit = numStr[0];
            var a = numStr;
            if (num != 9)
                a = Replace(numStr, '9', '9');

            var b = numStr;
            if (num != 1)
                b = Replace(numStr, '1', '0');

            return int.Parse(a) - int.Parse(b);

            string Replace(string str, char firstDigitTgt, char tgt)
            {
                if (firstDigit != firstDigitTgt)
                    return str.Replace(firstDigit, firstDigitTgt);
                else
                    for (int i = 1; i < str.Length; i++)
                        if (str[i] != tgt && str[i] != firstDigit)
                            return str.Replace(str[i], tgt);
                return str;
            }
        }
    }
}