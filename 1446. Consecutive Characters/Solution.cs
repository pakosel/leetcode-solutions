using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ConsecutiveCharacters
{
    public class Solution
    {
        public int MaxPower(string s)
        {
            int max = 1;
            int currMax = 1;
            var prev = s[0];

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == prev)
                    currMax++;
                else
                {
                    max = Math.Max(max, currMax);
                    currMax = 1;
                }
                prev = s[i];
            }
            max = Math.Max(max, currMax);

            return max;
        }
    }
}