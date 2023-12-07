using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace LargestOddNumberInString
{
    public class Solution
    {
        public string LargestOddNumber(string num)
        {
            for (int i = num.Length - 1; i >= 0; i--)
                if ((num[i] - '0') % 2 == 1)
                    return num[..(i + 1)];
            return "";
        }
    }
}