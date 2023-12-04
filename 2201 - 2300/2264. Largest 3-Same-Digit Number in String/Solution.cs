using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace Largest3SameDigitNumberInString
{
    public class Solution
    {
        public string LargestGoodInteger(string num)
        {
            var max = -1;
            for (int i = 2; i < num.Length && max < 9; i++)
                if (num[i] == num[i - 1] && num[i - 1] == num[i - 2])
                    max = Math.Max(max, num[i] - '0');
            if (max >= 0)
                return $"{max}{max}{max}";
            return "";
        }
    }
}