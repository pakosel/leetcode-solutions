using System;
using System.Collections.Generic;

namespace LongestSubstringWithoutRepeatingCharacters
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var max = 0;
            var arr = new bool[126];
            var left = 0;
            var right = -1;
            while (++right < s.Length && max < 95)
            {
                var c = s[right] - ' ';
                while (arr[c] && left < right)
                    arr[s[left++] - ' '] = false;
                arr[c] = true;
                max = Math.Max(max, right - left + 1);
            }
            return max;
        }
    }
    public class Solution2020
    {
        public int LengthOfLongestSubstring(string s)
        {
            int length = s.Length, ans = 0;
            int start = 0;

            Dictionary<char, int> map = new Dictionary<char, int>();

            for (int i = 0; i < length; i++)
            {
                if (map.ContainsKey(s[i]))
                {
                    if (map[s[i]] >= start)
                    {
                        start = map[s[i]];
                    }
                }

                ans = System.Math.Max(ans, i - start + 1);
                map[s[i]] = i + 1;
            }
            return ans;
        }
    }


}