using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace RemovingStarsFromString
{
    public class Solution
    {
        public string RemoveStars(string s)
        {
            var stack = new Stack<char>();
            foreach (var c in s)
                if (c == '*')
                    stack.Pop();
                else
                    stack.Push(c);

            return string.Join("", stack.Reverse());
        }
    }
}