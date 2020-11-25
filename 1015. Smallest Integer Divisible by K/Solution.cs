using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace SmallestIntegerDivisibleByK
{
    public class Solution
    {
        public int SmallestRepunitDivByK(int K)
        {
            int len = 1;
            HashSet<int> mods = new HashSet<int>();
            int mod = 1 % K;
            mods.Add(mod);
            while (mod != 0)
            {
                int n = mod * 10 + 1;
                mod = n % K;
                len++;
                if (mods.Contains(mod))
                    return -1;
                else
                    mods.Add(mod);
            }

            return len;
        }
    }
}