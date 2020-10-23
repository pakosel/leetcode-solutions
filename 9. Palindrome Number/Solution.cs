using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace PalindromeNumber
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            var s = x.ToString();
            int len = s.Length;
            if (len == 1)
                return true;

            for (int i = 0; i < len / 2; i++)
                if (s[i] != s[len - i - 1])
                    return false;

            return true;
        }
    }
}