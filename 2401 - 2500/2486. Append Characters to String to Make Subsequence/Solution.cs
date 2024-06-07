using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace AppendCharactersToStringToMakeSubsequence
{
    public class Solution
    {
        public int AppendCharacters(string s, string t)
        {
            int iS = 0, iT = 0, lenS = s.Length, lenT = t.Length;

            while (iS < lenS && iT < lenT)
            {
                if (s[iS] == t[iT])
                    iT++;
                iS++;
            }

            return lenT - iT;
        }
    }
}