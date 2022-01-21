using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MinimumLengthOfStringAfterDeletingSimilarEnds
{
    public class Solution
    {
        public int MinimumLength(string s)
        {
            var left = 0;
            var right = s.Length - 1;
            while (left < right)
            {
                if (s[left] != s[right])
                    break;
                var c = s[left];
                while (left <= right && s[left] == c)
                    left++;
                while (right >= left && s[right] == c)
                    right--;
            }

            return right - left + 1;
        }
    }
}