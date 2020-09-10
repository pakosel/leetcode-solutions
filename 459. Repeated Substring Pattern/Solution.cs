using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace RepeatedSubstringPattern
{
    public class Solution
    {
        public bool RepeatedSubstringPattern(string s)
        {
            int len = s.Length;
            if (len < 2)
                return false;

            for (int i = 2; i < 5000; i++)
            {
                if (i > len / 2)
                    break;
                if (len % i == 0)
                    if (CheckConcatenation(s, i))
                        return true;
            }

            //check if all characters are the same
            char first = s[0];
            for (int i = 1; i < len; i++)
                if (s[i] != first)
                    return false;

            return true;
        }

        private bool CheckConcatenation(string s, int multi)
        {
            int div = s.Length / multi;
            for (int i = 0; i < div; i++)
            {
                char first = s[i];
                for (int j = 1; j < multi; j++)
                    if (s[i + j * div] != first)
                        return false;
            }
            return true;
        }
    }
}