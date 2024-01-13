using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace DetermineIfStringHalvesAreAlike
{
    public class Solution_2024
    {
        public bool HalvesAreAlike(string s)
        {
            var len = s.Length;
            var cnt = 0;
            for (int i = 0; i < len; i++)
                if (IsVowel(s[i]))
                    if (i < len / 2)
                        cnt++;
                    else
                        cnt--;
            return cnt == 0;

            static bool IsVowel(char c) =>
                c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U';
        }
    }
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