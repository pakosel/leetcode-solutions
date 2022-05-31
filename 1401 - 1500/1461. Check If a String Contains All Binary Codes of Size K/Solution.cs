using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace CheckIfStringContainsAllBinaryCodesOfSizeK
{
    public class Solution
    {
        public bool HasAllCodes(string s, int k)
        {
            var set = new HashSet<int>();
            var tgt = (1 << k);
            var mask = (1 << k) - 1;
            var num = 0;
            int i = -1;

            while(++i < s.Length && set.Count < tgt)
            {
                num = (num << 1) + (s[i] - '0');
                num &= mask;
                if(i >= k-1)
                    set.Add(num);
            }

            return set.Count == tgt;
        }
    }
}