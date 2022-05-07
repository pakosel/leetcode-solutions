using System.Collections.Generic;
using System.Linq;
using System;
using System.Text.RegularExpressions;

namespace ImplementStackUsingQueues
{
    public class MyStack_v1
    {
        Queue<int> Q;
        public MyStack_v1()
        {
            Q = new();
        }

        public void Push(int x)
        {
            var queue = new Queue<int>(Q);
            Q.Clear();
            Q.Enqueue(x);
            while(queue.Count > 0)
                Q.Enqueue(queue.Dequeue());
        }

        public int Pop() => Q.Dequeue();

        public int Top() => Q.Peek();
        public bool Empty() => Q.Count == 0;
    }

    public class MyStack_v0
    {
        Queue<int> Q1;
        Queue<int> Q2;
        public MyStack_v0()
        {
            Q1 = new();
            Q2 = new();
        }

        public void Push(int x)
        {
            if (Q2.Count > 0)
                Q2.Enqueue(x);
            else
                Q1.Enqueue(x);
        }

        public int Pop()
        {
            var src = Q1.Count > 0 ? Q1 : Q2;
            var tgt = Q1.Count > 0 ? Q2 : Q1;
            while (src.Count > 1)
                tgt.Enqueue(src.Dequeue());
            return src.Dequeue();
        }

        public int Top()
        {
            var src = Q1.Count > 0 ? Q1 : Q2;
            var tgt = Q1.Count > 0 ? Q2 : Q1;
            while (src.Count > 1)
                tgt.Enqueue(src.Dequeue());
            var peek = src.Dequeue();
            tgt.Enqueue(peek);
            return peek;
        }

        public bool Empty()
        {
            return Q1.Count == 0 && Q2.Count == 0;
        }
    }
}