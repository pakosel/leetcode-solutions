using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace StrongPasswordCheckerII
{
    public class Solution
    {
        public bool StrongPasswordCheckerII(string password)
        {
            bool has8Char = (password.Length > 7);
            bool hasLowLetter = false;
            bool hasUpLetter = false;
            bool hasDigit = false;
            bool hasSpecial = false;
            for (int i = 0; i < 26; i++)
            {
                if (password.Contains((char)('a' + i)))
                    hasLowLetter = true;
                if (password.Contains((char)('A' + i)))
                    hasUpLetter = true;
            }
            for (int i = 0; i < 10; i++)
                if (password.Contains((char)('0' + i)))
                    hasDigit = true;
            foreach (var c in new char[] { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+' })
                if (password.Contains(c))
                    hasSpecial = true;
            
            var noTwoSame = true;
            for (int i = 1; i < password.Length; i++)
                if (password[i - 1] == password[i])
                {
                    noTwoSame = false;
                    break;
                }

            return has8Char && hasLowLetter && hasUpLetter && hasDigit && hasSpecial && noTwoSame;
        }
    }
}