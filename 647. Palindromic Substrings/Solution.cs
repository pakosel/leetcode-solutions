using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace PalindromicSubstrings
{
    public class Solution
    {
        int palindromes = 0;

        public int CountSubstrings(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                CheckPalindrome(s, i, i);
                CheckPalindrome(s, i, i + 1);
            }
            return palindromes;
        }

        private void CheckPalindrome(string s, int left, int right)
        {
            int len = s.Length;
            while (left >= 0 && right < len)
                if (s[left--] == s[right++])
                    palindromes++;
                else
                    break;
        }
    }
}