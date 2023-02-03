using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ZigzagConversion
{
    public class Solution
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1)
                return s;
            var sb = new StringBuilder();
            var inc = numRows + numRows - 2;
            for (int r = 0; r < numRows; r++)
            {
                var idx = r;
                while (idx < s.Length)
                {
                    sb.Append(s[idx]);
                    if (r > 0 && r < numRows - 1 && idx + inc - 2*r < s.Length)
                        sb.Append(s[idx + inc - 2*r]);
                    idx += inc;
                }
            }
            return sb.ToString();
        }
    }
}