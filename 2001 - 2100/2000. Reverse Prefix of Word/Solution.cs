using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace ReversePrefixOfWord
{
    public class Solution
    {
        public string ReversePrefix(string word, char ch)
        {
            var idx = word.IndexOf(ch);
            var sb = new StringBuilder();
            for (int i = idx; i >= 0; i--)
                sb.Append(word[i]);
            sb.Append(word[(idx + 1)..]);
            return sb.ToString();
        }
    }
}