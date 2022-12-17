using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace EvaluateReversePolishNotation
{
    public class Solution
    {
        public int EvalRPN(string[] tokens)
        {
            var stack = new Stack<int>();
            int right = 0;
            foreach (var t in tokens)
                switch (t)
                {
                    case "*":
                        stack.Push(stack.Pop() * stack.Pop());
                        break;
                    case "+":
                        stack.Push(stack.Pop() + stack.Pop());
                        break;
                    case "-":
                        right = stack.Pop();
                        stack.Push(stack.Pop() - right);
                        break;
                    case "/":
                        right = stack.Pop();
                        stack.Push(stack.Pop() / right);
                        break;
                    default:
                        stack.Push(int.Parse(t));
                        break;
                }
            return stack.Pop();
        }
    }
}