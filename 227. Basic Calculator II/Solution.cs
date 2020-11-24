using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace BasicCalculatorII
{
    public class Solution
    {
        Stack<int> stack = new Stack<int>();
        public int Calculate(string s)
        {
            s = s.Replace(" ", "");

            int i=0;
            int currNum = 0;
            char currOper = (char)0;
            while(i < s.Length)
            {
                if(char.IsDigit(s[i]))
                {
                    currNum = Consume(s, ref i);
                    stack.Push(currNum);
                }
                else
                {
                    currOper = s[i++];
                    if(currOper == '*' || currOper == '/')
                    {
                        int val = DoOper(stack.Pop(), Consume(s, ref i), currOper);
                        stack.Push(val);
                    }
                    else 
                    {
                        ConsumeStack();
                        stack.Push(currOper);
                    }
                }
            }
            ConsumeStack();

            return stack.Pop();
        }

        private void ConsumeStack()
        {
            while(stack.Count > 1)
            {
                int e1 = stack.Pop();
                char oper = (char)stack.Pop();
                int e2 = stack.Pop();
                int res = DoOper(e2, e1, oper);
                //Console.WriteLine($"Pushing {res}");
                stack.Push(res);
            }
        }

        private int Consume(string s, ref int i)
        {
            string res = "";
            while(i < s.Length && char.IsDigit(s[i]))
                res += s[i++];
            return int.Parse(res);
        }

        private int DoOper(int e1, int e2, char oper)
        {
            //Console.WriteLine($"exe: {e1}{oper}{e2}");
            switch (oper)
            {
                case '+':
                    return e1 + e2;
                case '-':
                    return e1 - e2;
                case '*':
                    return e1 * e2;
                case '/':
                    return e1 / e2;
            }
            return 0;
        }
    }

    public class Solution_Recursive
    {
        public int Calculate(string s)
        {
            return Eval(s);
        }

        private int Eval(string s)
        {
            Console.WriteLine(s);
            int idx = FindNextOper(s, '+', '-');
            if(idx == -1)
                idx = FindNextOper(s, '*', '/');
            if(idx > 0)
            {
                int e1 = Eval(s.Substring(0, idx));
                int e2 = Eval(s.Substring(idx + 1));

                return DoOper(e1, e2, s[idx]);
            }
            
            return int.Parse(s);
        }

        private int FindNextOper(string s, char op1, char op2)
        {
            int idx1 = s.LastIndexOf(op1);
            int idx2 = s.LastIndexOf(op2);
            int idx = Math.Max(idx1, idx2);

            return idx;            
        }

        private int DoOper(int e1, int e2, char oper)
        {
            //Console.WriteLine($"exe: {e1}{oper}{e2}");
            switch (oper)
            {
                case '+':
                    return e1 + e2;
                case '-':
                    return e1 - e2;
                case '*':
                    return e1 * e2;
                case '/':
                    return e1 / e2;
            }
            return 0;
        }
    }
}