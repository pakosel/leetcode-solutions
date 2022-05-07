using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ShiftingLetters
{
    public class Solution
    {
        public string ShiftingLetters(string S, int[] shifts)
        {
            int len = S.Length;
            const int mod = 'z' - 'a' + 1;
            char[] res = new char[len];

            for (int i = len - 1; i >= 0; i--)
            {
                res[i] = (char)((S[i] - 'a' + shifts[i]) % mod + 'a');
                if(i > 0)
                    shifts[i - 1] += shifts[i] % mod;
            }

            return new string(res);
        }
    }
}