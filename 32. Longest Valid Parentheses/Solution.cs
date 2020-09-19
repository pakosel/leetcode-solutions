using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace LongestValidParentheses
{
    public class Solution_Stack
    {
        //Approach #3 from https://leetcode.com/problems/longest-valid-parentheses/solution/
        public int LongestValidParentheses(string s)
        {
            int max = 0;
            Stack<int> stack = new Stack<int>();
            stack.Push(-1);

            for (int i = 0; i < s.Length; i++)
                if(s[i] == '(')
                    stack.Push(i);
                else
                {
                    stack.Pop();
                    if(stack.Count == 0)
                        stack.Push(i);
                    max = Math.Max(max, i - stack.Peek());
                }

            return max;
        }
    }

    public class Solution
    {
        public int LongestValidParentheses(string s)
        {
            int max = 0;
            for (int i = 0; i < s.Length - 1; i++)
                if (s[i] == '(')
                    max = Math.Max(max, MaxLongest(s, i));

            return max;
        }

        private int MaxLongest(string s, int start)
        {
            int len = s.Length;
            int max = 0;
            int balance = 0;
            int i = start;
            while (i < len)
            {
                if (s[i] == '(')
                    balance++;
                else
                    balance--;

                if (balance == 0)
                    max = i + 1 - start;
                if (balance < 0)
                    break;
                i++;
            }

            return max;
        }
    }
}