using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace CheckIfNumberHasEqualDigitCountAndDigitValue
{
    public class Solution
    {
        public bool DigitCount(string num)
        {
            var arr = new int[10];

            foreach (var c in num)
                arr[c - '0']++;
            
            for (int i = 0; i < num.Length; i++)
                if (arr[i] != (num[i] - '0'))
                    return false;
            return true;
        }
    }
}