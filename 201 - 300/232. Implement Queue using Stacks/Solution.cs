using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ImplementQueueUsingStacks
{
    public class MyQueue
    {
        Stack<int> stack;
        int peek = -1;

        public MyQueue()
        {
            stack = new(100);
        }

        public void Push(int x)
        {
            if (peek == -1)
                peek = x;
            stack.Push(x);
        }

        public int Pop()
        {
            var temp = new Stack<int>(100);
            while (stack.Count > 1)
                temp.Push(stack.Pop());
            var res = stack.Pop();
            peek = temp.Count > 0 ? temp.Peek() : -1;
            while (temp.Count > 0)
                stack.Push(temp.Pop());
            return res;
        }

        public int Peek()
        {
            return peek;
        }

        public bool Empty()
        {
            return stack.Count == 0;
        }
    }
}