using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace BackspaceStringCompare
{
    public class Solution
    {
        public bool BackspaceCompare(string s, string t)
            => Read(s) == Read(t);

        private string Read(string s)
        {
            var stack = new Stack<char>();
            foreach (var c in s)
                if (c != '#')
                    stack.Push(c);
                else
                    stack.TryPop(out _);

            return new string(stack.ToArray());
        }
    }
}