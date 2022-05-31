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
            var tgt = (1 << k);     //number of all different values consisting of k bits
            var mask = (1 << k) - 1;
            var num = 0;
            int i = -1;

            while(++i < s.Length && set.Count < tgt)
            {
                num = (num << 1) + (s[i] - '0');
                num &= mask;    //turn k-th bit OFF (we're interested in values of length k-1 )
                if(i >= k-1)    //save num if we already have enough bits
                    set.Add(num);
            }

            return set.Count == tgt;
        }
    }
}