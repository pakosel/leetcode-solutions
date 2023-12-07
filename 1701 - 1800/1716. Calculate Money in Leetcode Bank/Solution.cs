using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace CalculateMoneyInLeetcodeBank
{
    public class Solution
    {
        public int TotalMoney(int n)
        {
            var start = 1;
            var res = 0;
            while (n >= 7)
            {
                res += (start + start + 6) * 7 / 2;
                n -= 7;
                start++;
            }
            res += (start + start + (n - 1)) * n / 2;
            return res;
        }
    }
}