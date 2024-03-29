using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace NumberOfWaysToSelectBuildings
{
    public class Solution
    {
        long[][] Arr = new long[1_00_000][];    //count number of '01' and '10' sequences

        public long NumberOfWays(string s)
        {
            FillArr(s);
            long res = 0;
            for (int i = 0; i <= s.Length - 3; i++)
                if (s[i] == '0')
                    res += Arr[i + 1][1];
                else
                    res += Arr[i + 1][0];

            return res;
        }

        private void FillArr(string s)
        {
            var last = s.Length - 1;
            long cnt_01 = (s[last - 1] == '0' && s[last] == '1') ? 1 : 0;
            long cnt_10 = (s[last - 1] == '1' && s[last] == '0') ? 1 : 0;
            Arr[s.Length - 2] = new long[] { cnt_01, cnt_10 }; // {#01, #10}
            
            long zeros = (s[last] == '0' ? 1 : 0);  //count of 0's
            long ones = (s[last] == '1' ? 1 : 0);  //count of 1's
            if (s[last - 1] == '0')
                zeros++;
            if (s[last - 1] == '1')
                ones++;

            for (int i = s.Length - 3; i > 0; i--)
            {
                if (s[i] == '0')
                {
                    cnt_01 += ones;
                    zeros++;
                }
                else
                {
                    cnt_10 += zeros;
                    ones++;
                }
                Arr[i] = new long[] { cnt_01, cnt_10 };
            }
        }
    }
}