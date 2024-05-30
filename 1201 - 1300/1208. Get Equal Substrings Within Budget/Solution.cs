using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace GetEqualSubstringsWithinBudget
{
    public class Solution
    {
        public int EqualSubstring(string s, string t, int maxCost)
        {
            var len = s.Length;
            var arr = new int[len];

            for (int i = 0; i < len; i++)
                arr[i] = Math.Abs(s[i] - t[i]);
            int left = 0, right = 0, res = 0, curr = 0;
            while (right < len)
            {
                while (curr <= maxCost && right < len)
                {
                    res = Math.Max(res, right - left);
                    curr += arr[right++];
                }
                if (right == len)
                {
                    if (curr <= maxCost)
                        res = Math.Max(res, right - left);
                    break;
                }
                while (curr > maxCost && left < right)
                    curr -= arr[left++];
            }
            return res;
        }
    }
}