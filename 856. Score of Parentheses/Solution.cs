using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ScoreOfParentheses
{
    public class Solution
    {
        public int ScoreOfParentheses(string s)
        {
            var stack = new Stack<int>();
            foreach (var c in s)
                if (c == '(')
                    stack.Push(0);
                else
                {
                    var curr = 0;
                    while (stack.Peek() != 0)
                        curr += stack.Pop();
                    stack.Pop();
                    if (curr == 0)
                        stack.Push(1);
                    else
                        stack.Push(2 * curr);
                }

            var res = 0;
            while (stack.Count > 0)
                res += stack.Pop();
            return res;
        }
    }

}