using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace Base7
{
    public class Solution
    {
        public string ConvertToBase7(int num)
        {
            if (Math.Abs(num) < 7)
                return num.ToString();

            string res = "";
            string sign = num < 0 ? "-" : "";
            num = Math.Abs(num);
            
            int divisor = 7*7*7*7*7*7*7*7*7;
            while (divisor > 1)
            {
                int div = num / divisor;

                if (div > 0 || res.Length > 0)
                {
                    res += div;
                    num = num % divisor;
                }
                divisor = divisor / 7;
            }
            res += num;

            return sign + res;
        }
    }
}