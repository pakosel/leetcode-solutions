using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace DecodedStringAtIndex
{
    public class Solution
    {
        public string DecodeAtIndex(string S, int K)
        {
            var sb = new StringBuilder();
            int i = 0;
            while (sb.Length < K)
            {
                var c = S[i++];
                if (char.IsDigit(c))
                {
                    var curr = sb.ToString();
                    for (int x = 1; x < c-'0' && sb.Length < K; x++)
                        sb.Append(curr);
                }
                else
                    sb.Append(c);
            }
            return sb.ToString()[K - 1].ToString();
        }
    }
}