using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace BasicCalculatorII
{
    public class Solution
    {
        public int Calculate(string s)
        {
            var stack = new Stack<int>();
            stack.Push(0);
            var curr = 0;
            var op = '+';

            int i = -1;
            while(++i < s.Length)
            {
                if(s[i] == ' ')
                    continue;
                else if(char.IsDigit(s[i]))
                    curr = 10*curr + (s[i] - '0');
                else
                {
                    switch(op)
                    {
                        case '+':
                            stack.Push(curr);
                            break;
                        case '-':
                            stack.Push(-1*curr);
                            break;
                        case '*':
                            stack.Push(stack.Pop() * curr);
                            break;
                        case '/':
                            stack.Push(stack.Pop() / curr);
                            break;
                    }
                    curr = 0;
                    op = s[i];
                }
            }
            var res = Evaluate(op, stack.Pop(), curr);
            while(stack.Count > 0)
                res += stack.Pop();
            return res;
        }

        private int Evaluate(char oper, int left, int right) => oper == '*' ? left * right : oper == '/' ? left / right : oper == '+' ? left+right : left-right;
    }
}