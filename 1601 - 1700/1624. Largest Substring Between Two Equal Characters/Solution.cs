using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace LargestSubstringBetweenTwoEqualCharacters
{
    public class Solution
    {
        public int MaxLengthBetweenEqualCharacters(string s)
        {
            var arr = new int[26];
            Array.Fill(arr, -1);
            var res = -1;
            for (int i = 0; i < s.Length; i++)
                if (arr[s[i] - 'a'] == -1)
                    arr[s[i] - 'a'] = i;
                else
                    res = Math.Max(res, i - arr[s[i] - 'a'] - 1);
            return res;
        }
    }
}