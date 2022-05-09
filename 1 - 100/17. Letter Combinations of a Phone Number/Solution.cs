using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace LetterCombinationsPhoneNumber
{
    public class Solution
    {
        public IList<string> LetterCombinations(string digits)
        {
            if(digits.Length == 0)
                return new string[0];
            var first = Map(digits[0]);
            var subst = LetterCombinations(digits.Substring(1));

            if (subst.Count == 0)
                return first;

            var res = new string[first.Count * subst.Count];
            var i = 0;

            foreach (var c in first)
                foreach (var s in subst)
                    res[i++] = (c + s);
            return res;
        }

        private IList<string> Map(char digit)
        {
            switch (digit)
            {
                case '2':
                    return new string[] { "a", "b", "c" };
                case '3':
                    return new string[] { "d", "e", "f" };
                case '4':
                    return new string[] { "g", "h", "i" };
                case '5':
                    return new string[] { "j", "k", "l" };
                case '6':
                    return new string[] { "m", "n", "o" };
                case '7':
                    return new string[] { "p", "q", "r", "s" };
                case '8':
                    return new string[] { "t", "u", "v" };
                case '9':
                    return new string[] { "w", "x", "y", "z" };
                default:
                    return new string[0];
            }
        }
    }
}