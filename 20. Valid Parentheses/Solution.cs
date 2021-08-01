using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ValidParentheses
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();

            foreach (var c in s)
            {
                if (IsOpen(c))
                    stack.Push(c);
                else
                    if (stack.Count == 0 || !DoMatch(stack.Pop(), c))
                    return false;
            }

            return stack.Count == 0;
        }

        private bool IsOpen(char c) => c == '(' || c == '{' || c == '[';

        private bool DoMatch(char open, char close)
        {
            if (open == '(' && close != ')' ||
               open == '[' && close != ']' ||
               open == '{' && close != '}')
                return false;
            return true;
        }
    }
}