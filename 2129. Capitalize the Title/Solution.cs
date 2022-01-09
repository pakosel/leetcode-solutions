using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace CapitalizeTheTitle
{
    public class Solution
    {
        public string CapitalizeTitle(string s)
        {
            int len = s.Length;
            var res = new StringBuilder();
            var first = true;
            for (int i = 0; i < len; i++)
                if (first)
                {
                    first = !first;
                    if (i >= len - 2 || s[i + 1] == ' ' || s[i + 2] == ' ')
                        res.Append(char.ToLower(s[i]));
                    else
                        res.Append(char.ToUpper(s[i]));
                }
                else
                {
                    res.Append(char.ToLower(s[i]));
                    if (s[i] == ' ')
                        first = !first;
                }

            return res.ToString();
        }
    }
}