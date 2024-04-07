using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MaximumNestingDepthOfTheParentheses
{
    public class Solution
    {
        public int MaxDepth(string s)
        {
            var res = 0;
            var stack = new Stack<char>();
            foreach (var c in s)
                if (c == '(')
                {
                    stack.Push(c);
                    res = Math.Max(res, stack.Count);
                }
                else if (c == ')')
                    stack.Pop();
            return res;
        }
    }
}