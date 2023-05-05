using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MaximumNumberOfVowelsInSubstringOfGivenLength
{
    public class Solution
    {
        public int MaxVowels(string s, int k)
        {
            var res = 0;
            for (int i = 0; i < k && i < s.Length; i++)
                if (IsVowel(s[i]))
                    res++;
            var max = res;
            for (int i = k; i < s.Length; i++)
            {
                if (IsVowel(s[i - k]))
                    res--;
                if (IsVowel(s[i]))
                    res++;
                max = Math.Max(max, res);
            }

            return max;

            bool IsVowel(char c) => c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
        }
    }
}