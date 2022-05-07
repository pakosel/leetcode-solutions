using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace The132Pattern
{
    public class Solution
    {
        public bool Find132pattern(int[] nums)
        {
            var min = int.MaxValue;
            var stack = new Stack<(int i, int k)>();
            foreach (var n in nums)
                if (n < min)
                    min = n;
                else
                {
                    if (stack.Count > 0 && stack.Peek().i == min)
                    {
                        if (stack.Peek().k < n)
                        {
                            stack.Pop();
                            stack.Push((min, n));
                        }
                    }
                    else
                        stack.Push((min, n));
                    Optimize(stack);
                
                    foreach (var c in stack)
                        if (c.i < n && c.k > n)
                            return true;
                }

            return false;
        }

        private void Optimize(Stack<(int i, int k)> stack)
        {
            var last = stack.Pop();
            while (stack.Count > 0 && stack.Peek().i >= last.i && stack.Peek().k <= last.k)
                stack.Pop();
            stack.Push(last);
        }
    }
}