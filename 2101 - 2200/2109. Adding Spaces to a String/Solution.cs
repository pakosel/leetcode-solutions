using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace AddingSpacesToString
{
    public class Solution
    {
        public string AddSpaces(string s, int[] spaces)
        {
            var sb = new StringBuilder();
            var idx = 0;
            for (int i = 0; i < spaces.Length; i++)
            {
                while (idx < spaces[i])
                    sb.Append(s[idx++]);
                sb.Append(' ');
            }
            sb.Append(s.Substring(idx));
            return sb.ToString();
        }
    }
}