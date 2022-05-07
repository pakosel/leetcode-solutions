using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MinimumRemoveToMakeValidParentheses
{
    public class Solution
    {
        public string MinRemoveToMakeValid(string s)
        {
            var sb = new StringBuilder();
            var stack = new Stack<int>();
            foreach (var c in s)
                if (c == ')')
                {
                    if (stack.Count != 0)
                    {
                        stack.Pop();
                        sb.Append(c);
                    }
                }
                else
                {
                    if (c == '(')
                        stack.Push(sb.Length);
                    sb.Append(c);
                }
            while (stack.Count > 0)
                sb.Remove(stack.Pop(), 1);

            return sb.ToString();
        }
    }
}