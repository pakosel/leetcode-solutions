using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace FirstUniqueCharacterInString
{
    public class Solution
    {
        public int FirstUniqChar(string s)
        {
            var arr = new int[26];
            Array.Fill(arr, -1);
            int i = 0;
            foreach (var c in s)
                if (arr[c - 'a'] == -1)
                    arr[c - 'a'] = i++;
                else
                    arr[c - 'a'] = -1 * (++i);
            var res = int.MaxValue;
            foreach (var idx in arr)
                if (idx >= 0)
                    res = Math.Min(res, idx);
            return res == int.MaxValue ? -1 : res;
        }
    }
}