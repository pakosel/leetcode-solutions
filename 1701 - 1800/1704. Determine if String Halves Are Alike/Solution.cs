using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace DetermineIfStringHalvesAreAlike
{
    public class Solution
    {
        public bool HalvesAreAlike(string s)
        {
            var len = s.Length;
            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            var vowA = 0;
            var vowB = 0;

            for (int i = 0; i < len; i++)
            {
                var c = char.ToLower(s[i]);
                if (vowels.Contains(c))
                    if (i < len / 2)
                        vowA++;
                    else
                        vowB++;
            }

            return vowA == vowB;
        }
    }
}