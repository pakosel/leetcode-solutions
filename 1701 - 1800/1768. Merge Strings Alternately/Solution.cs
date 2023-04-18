using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MergeStringsAlternately
{
    public class Solution
    {
        public string MergeAlternately(string word1, string word2)
        {
            var sb = new StringBuilder();
            int i1 = 0, i2 = 0;

            while (i1 < word1.Length || i2 < word2.Length)
            {
                if (i1 < word1.Length)
                    sb.Append(word1[i1++]);
                if (i2 < word2.Length)
                    sb.Append(word2[i2++]);
            }
            return sb.ToString();
        }
    }
}