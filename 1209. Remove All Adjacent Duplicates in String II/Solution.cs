using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace RemoveAllAdjacentDuplicatesInStringII
{
    public class Solution
    {
        public string RemoveDuplicates(string s, int k)
        {
            var stack = new Stack<(char c, int cnt)>();
            foreach (var c in s)
            {
                if (stack.Count > 0 && stack.Peek().c == c)
                {
                    var pop = stack.Pop();
                    pop.cnt++;
                    if (pop.cnt < k)
                        stack.Push(pop);
                }
                else
                    stack.Push((c, 1));
            }
            var sb = new StringBuilder();
            while (stack.Count > 0)
            {
                var pop = stack.Pop();
                for (int i = 0; i < pop.cnt; i++)
                    sb.Append(pop.c);
            }
            return string.Join("", sb.ToString().Reverse());
        }
    }
}