using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace AddBinary
{
    public class Solution
    {
        public string AddBinary(string a, string b)
        {
            int carry = 0;
            int i = a.Length - 1;
            int j = b.Length - 1;

            var res = new StringBuilder();
            while (i >= 0 || j >= 0)
            {
                int val = (i >= 0 ? (a[i--] - '0') : 0) +
                          (j >= 0 ? (b[j--] - '0') : 0) + carry;
                res.Insert(0, val % 2);
                carry = val / 2;
            }
            if (carry != 0)
                res.Insert(0, carry);
            return res.ToString();
        }
    }
}