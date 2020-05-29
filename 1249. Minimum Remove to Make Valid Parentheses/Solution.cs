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
            int balance = 0;
            var res = new StringBuilder();
            var openPos = new Stack<int>();
            int i = 0;
            foreach (var c in s)
                switch (c)
                {
                    case '(':
                        balance++;
                        res.Append(c);
                        openPos.Push(i++);
                        break;
                    case ')':
                        if (balance > 0)
                        {
                            balance--;
                            res.Append(c);
                            openPos.Pop();
                            i++;
                        }
                        break;
                    default:
                        res.Append(c);
                        i++;
                        break;
                }

            while (balance > 0)
            {
                var pos = openPos.Pop();
                res.Remove(pos, 1);
                balance--;
            }

            return res.ToString();
        }
    }
}