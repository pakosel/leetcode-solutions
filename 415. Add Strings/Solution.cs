using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace AddStrings
{
    public class Solution
    {
        public string AddStrings(string num1, string num2)
        {
            var res = new StringBuilder();
            int carry = 0;
            int l1 = num1.Length - 1;
            int l2 = num2.Length - 1;
            int i = 0;

            while (l1 - i >= 0 || l2 - i >= 0)
            {
                var d1 = l1 - i >= 0 ? num1[l1 - i] - '0' : 0;
                var d2 = l2 - i >= 0 ? num2[l2 - i] - '0' : 0;
                res.Insert(0, (d1 + d2 + carry) % 10);

                carry = (d1 + d2 + carry) / 10;
                i++;
            }
            if (carry != 0)
                res.Insert(0, carry);

            return res.ToString();
        }
    }
}