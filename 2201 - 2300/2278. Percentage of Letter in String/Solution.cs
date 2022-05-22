using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace PercentageOfLetterInString
{
    public class Solution
    {
        public int PercentageLetter(string s, char letter)
        {
            var cnt = 0;
            foreach (var c in s)
                if (c == letter)
                    cnt++;
            return cnt * 100 / s.Length;
        }
    }
}