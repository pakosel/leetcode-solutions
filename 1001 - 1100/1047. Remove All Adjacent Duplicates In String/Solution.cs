using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace RemoveAllAdjacentDuplicatesInString
{
    public class Solution
    {
        public string RemoveDuplicates(string s)
        {
            var stack = new Stack<char>();
            foreach (var c in s)
                if (stack.Count > 0 && stack.Peek() == c)
                    stack.Pop();
                else
                    stack.Push(c);
            return string.Join("", stack.Reverse());
        }
    }
}