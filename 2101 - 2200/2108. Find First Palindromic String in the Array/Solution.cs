using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace FindFirstPalindromicStringInTheArray
{
    public class Solution
    {
        public string FirstPalindrome(string[] words)
        {
            return words.FirstOrDefault(w => IsPalindromic(w)) ?? "";

            bool IsPalindromic(string s)
            {
                int left = 0, right = s.Length - 1;
                while (left < right)
                    if (s[left++] != s[right--])
                        return false;
                return true;
            }
        }
    }
}