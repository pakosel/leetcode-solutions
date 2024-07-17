using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace ReverseSubstringsBetweenEachPairOfParentheses
{
    public class Solution
    {
        public string ReverseParentheses(string s)
        {
            var S = s.ToArray();
            var q = new Queue<(int o, int c)>();
            var stackInt = new Stack<int>();
            for (int i = 0; i < s.Length; i++)
                if (s[i] == '(')
                    stackInt.Push(i);
                else if (s[i] == ')')
                    q.Enqueue((stackInt.Pop(), i));

            while (q.Count() > 0)
            {
                var pair = q.Dequeue();
                Reverse(pair.o, pair.c);
            }

            return new string(S).Replace("(", "").Replace(")", "");

            void Reverse(int start, int end)
            {
                while (start < end)
                    (S[start], S[end]) = (S[end--], S[start++]);
            }
        }
    }
}