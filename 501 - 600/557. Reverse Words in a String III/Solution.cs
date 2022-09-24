using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ReverseWordsInStringIII
{
    public class Solution
    {
        public string ReverseWords(string s)
        {
            var arr = s.Split(' ');
            var sb = new StringBuilder();
            foreach (var word in arr)
            {
                for (int i = word.Length - 1; i >= 0; i--)
                    sb.Append(word[i]);
                sb.Append(' ');
            }
            return sb.ToString().Trim(' ');
        }
    }
}