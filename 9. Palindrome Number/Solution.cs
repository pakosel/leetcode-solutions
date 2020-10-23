using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace PalindromeNumber
{
    public class Solution_NoString
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            int num = x;
            int reversed = num % 10;

            while (num / 10 > 0)
            {
                num /= 10;
                reversed *= 10;
                reversed += num % 10;
            }

            return x == reversed;
        }
    }
    public class Solution_ToString
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