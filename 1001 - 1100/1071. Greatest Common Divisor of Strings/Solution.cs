using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace GreatestCommonDivisorOfStrings
{
    public class Solution
    {
        public string GcdOfStrings(string str1, string str2)
        {
            var shorter = str1;
            var longer = str2;
            if (str1.Length > str2.Length)
                (shorter, longer) = (longer, shorter);

            for (int len = shorter.Length; len > 0; len--)
            {
                var substr = shorter.Substring(0, len);
                if (shorter.Length % len != 0 || longer.Length % len != 0)
                    continue;

                var concatShort = string.Join("", Enumerable.Range(0, shorter.Length / len).Select(_ => substr));
                var concatLong = string.Join("", Enumerable.Range(0, longer.Length / len).Select(_ => substr));
                if (concatShort == shorter && concatLong == longer)
                    return substr;
            }

            return "";
        }
    }
}