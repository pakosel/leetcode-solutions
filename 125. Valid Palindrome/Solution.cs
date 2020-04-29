using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ValidPalindrome
{
    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            s = s.ToLower();
            //var sb = System.Text.RegularExpressions.Regex.Replace(s, @"[^a-z0-9]+", "");
            //much faster with StringBuilder
            var sb = new StringBuilder();
            foreach (char value in s)
                if ((value >= 'a' && value <= 'z') || (value >= '0' && value <= '9'))
                    sb.Append(value);
            int len = sb.Length;
            if (len < 2)
                return true;
            for (int i = 0; i < len / 2; i++)
                if (sb[i] != sb[len - i - 1])
                    return false;
            return true;
        }
    }
}