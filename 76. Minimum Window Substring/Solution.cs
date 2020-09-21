using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MinimumWindowSubstring
{
    public class Solution
    {
        //Sliding window solution implementation
        public string MinWindow(string s, string t)
        {
            int minuses = 0;
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach(var c in t)
                if(dict.ContainsKey(c))
                    dict[c] = dict[c] - 1;
                else
                {
                    dict.Add(c, -1);
                    minuses++;
                }

            string res = "";
            int lenS = s.Length;
            int left = 0;
            int right = 0;
            while(left < lenS)
            {
                if(minuses > 0)
                {
                    if(right >= lenS)
                        break;
                    var key = s[right];
                    if(dict.ContainsKey(key))
                    {
                        dict[key] = dict[key] + 1;
                        if(dict[key] == 0)
                            minuses--;
                    }
                    right++;
                }
                else
                {
                    if(res.Length == 0 || right - left < res.Length) 
                        res = s.Substring(left, right - left);
                    var key = s[left];
                    if(dict.ContainsKey(key))
                    {
                        if(dict[key] == 0)
                            minuses++;
                        dict[key] = dict[key] - 1;
                    }
                    left++;
                }
            }

            return res;
        }
    }
}