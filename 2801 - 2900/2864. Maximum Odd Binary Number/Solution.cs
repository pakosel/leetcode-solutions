using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MaximumOddBinaryNumber
{
    public class Solution
    {
        public string MaximumOddBinaryNumber(string s)
        {
            var ones = s.Count(c => c == '1');
            var sb = new StringBuilder();
            for (int i = 0; i < ones - 1; i++)
                sb.Append('1');
            for (int i = 0; i < s.Length - ones; i++)
                sb.Append('0');
            sb.Append('1');
            return sb.ToString();
        }
    }
}