using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ValidPalindromeII
{
    public class Solution
    {
        public bool ValidPalindrome(string s, bool canSkip = true, int left = 0, int right = int.MaxValue)
        {
            right = Math.Min(right, s.Length - 1);
            while (left < right)
                if (s[left] == s[right])
                {
                    left++;
                    right--;
                }
                else if (canSkip)
                    return ValidPalindrome(s, false, left + 1, right) || ValidPalindrome(s, false, left, right - 1);
                else
                    return false;
            return true;
        }
    }
}