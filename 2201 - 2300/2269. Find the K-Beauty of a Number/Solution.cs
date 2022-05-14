using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace FindTheKBeautyOfNumber
{
    public class Solution
    {
        public int DivisorSubstrings(int num, int k)
        {
            var s = num.ToString();
            var res = 0;
            var start = 0;
            while (start <= s.Length - k)
            {
                var substr = s.Substring(start, k);
                var n = int.Parse(substr);
                if (n != 0 && num % n == 0)
                    res++;
                start++;
            }
            return res;
        }
    }
}