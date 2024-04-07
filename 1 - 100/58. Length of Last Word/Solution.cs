using System.Collections.Generic;
using System.Linq;
using System;

namespace LengthOfLastWord
{
    public class Solution
    {
        public int LengthOfLastWord(string s)
        {
            var last = s.Length - 1;
            while (s[last] == ' ')
                last--;
            var res = 0;
            while (last >= 0 && s[last--] != ' ')
                res++;
            return res;
        }
    }
}