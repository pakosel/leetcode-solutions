using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace ReverseVowelsOfString
{
    public class Solution
    {

        public string ReverseVowels(string s)
        {
            var vowels = new HashSet<char>(new char[] { 'a', 'e', 'i', 'o', 'u' });

            var stack = new Stack<char>();
            foreach (var c in s)
                if (IsVowel(c))
                    stack.Push(c);

            var sb = new StringBuilder();
            foreach (var c in s)
                if (IsVowel(c))
                    sb.Append(stack.Pop());
                else
                    sb.Append(c);

            return sb.ToString();

            bool IsVowel(char c) => vowels.Contains(char.ToLower(c));
        }
    }
}