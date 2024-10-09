using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MinimumNumberOfSwapsToMakeTheStringBalanced
{
    public class Solution
    {
        public int MinSwaps(string s)
        {
            var stack = new Stack<char>();
            foreach (var c in s)
                if (c == '[')
                    stack.Push(c);
                else
                    if (stack.Count > 0 && stack.Peek() == '[')
                    stack.Pop();
                else
                    stack.Push(c);
            var div = stack.Count / 4;
            var mod = stack.Count % 4;
            if (mod > 0)
                div++;
            return div;
        }
    }
}