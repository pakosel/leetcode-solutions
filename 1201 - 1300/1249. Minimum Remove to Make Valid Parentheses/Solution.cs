using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MinimumRemoveToMakeValidParentheses
{
    public class Solution2024
    {
        public string MinRemoveToMakeValid(string s)
        {
            int bal = 0;
            var sb = new StringBuilder();
            foreach (var c in s)
            {
                sb.Append(c);
                if (c == '(')
                    bal++;
                else if (c == ')')
                {
                    if (bal > 0)
                        bal--;
                    else
                        sb.Length--;
                }
            }
            int pos = sb.Length - 1;
            while (bal > 0)
            {
                while (sb[pos] != '(')
                    pos--;
                sb.Remove(pos, 1);
                bal--;
                pos--;
            }
            return sb.ToString();
        }
    }
    
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