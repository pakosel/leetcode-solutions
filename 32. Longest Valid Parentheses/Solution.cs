using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace LongestValidParentheses
{
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