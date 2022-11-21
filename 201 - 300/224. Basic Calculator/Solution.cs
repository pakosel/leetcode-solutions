using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace BasicCalculator
{
    public class Solution
    {
        public int Calculate(string s)
        {
            var stack = new Stack<Token>();
            if (s[0] == '-')
                stack.Push(Token.NumToken(0));
            int i = 0;
            while (i < s.Length)
            {
                var c = s[i++];
                if (char.IsDigit(c))
                {
                    if (stack.Count > 0 && stack.Peek().IsNum)
                        stack.Peek().Num = 10 * stack.Peek().Num + (c - '0');
                    else
                        stack.Push(Token.NumToken(c - '0'));
                }
                else if (c == '+' || c == '-')
                    stack.Push(Token.OperToken(c));
                else if (c == '(')
                    stack.Push(Token.BracketToken());
                else if (c == ')')
                    stack.Push(Token.NumToken(ConsumeStack()));
            }
            return ConsumeStack();

            int ConsumeStack()
            {
                var subStack = new Stack<Token>();
                while (stack.Count > 0)
                {
                    var token = stack.Pop();
                    if (token.IsBracket)
                        break;
                    else
                        subStack.Push(token);
                }
                var res = subStack.Count > 0 ? subStack.Pop().Num : 0;
                var oper = ' ';
                while (subStack.Count > 0)
                {
                    var token = subStack.Pop();
                    if (token.IsOper)
                        oper = token.Oper;
                    else    //num
                    {
                        if (oper == '+')
                            res += token.Num;
                        else
                            res -= token.Num;
                    }
                }
                return res;
            }
        }

        private class Token
        {
            public bool IsNum { get; set; }
            public bool IsBracket { get; set; }
            public bool IsOper { get; set; }
            public int Num { get; set; }
            public char Oper { get; set; }

            public static Token NumToken(int num) => new Token() { IsNum = true, Num = num };
            public static Token OperToken(char oper) => new Token() { IsOper = true, Oper = oper };
            public static Token BracketToken() => new Token() { IsBracket = true };
        }
    }
}