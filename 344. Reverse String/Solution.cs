using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace ReverseString
{
    public class Solution
    {
        public void ReverseString(char[] s)
        {
            var left = 0;
            var right = s.Length - 1;
            while (left < right)
                (s[left], s[right]) = (s[right--], s[left++]);
        }
    }
}