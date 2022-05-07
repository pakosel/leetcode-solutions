using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MinimumBitFlipsToConvertNumber
{
    public class Solution
    {
        public int MinBitFlips(int start, int goal)
        {
            var bin1 = ToBin(start);
            var bin2 = ToBin(goal);
            var res = 0;

            for (int i = 0; i < Math.Max(bin1.Length, bin2.Length); i++)
            {
                var b1 = i < bin1.Length ? bin1[i] : '0';
                var b2 = i < bin2.Length ? bin2[i] : '0';

                if (b1 != b2)
                    res++;
            }
            return res;
        }

        private string ToBin(int n)
        {
            var sb = new StringBuilder();
            while (n > 0)
            {
                sb.Append(n % 2);
                n = n >> 1;
            }
            return sb.ToString();
        }
    }
}