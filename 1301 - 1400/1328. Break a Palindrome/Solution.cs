using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace BreakPalindrome
{
    public class Solution
    {
        public string BreakPalindrome(string palindrome)
        {
            var len = palindrome.Length;
            if (len == 1)
                return "";

            var found = false;
            var i = 0;

            //replace first non-a occurence with 'a'
            //except for the middle character which won't break palindrome for any replacement
            while (i <= len / 2)
                if (palindrome[i] != 'a' && (len % 2 == 0 || i != len / 2))
                {
                    found = true;
                    break;
                }
                else
                    i++;

            var res = palindrome.ToArray();
            if (found)
                res[i] = 'a';
            else
                res[len - 1] = 'b';

            return new string(res);
        }
    }
}