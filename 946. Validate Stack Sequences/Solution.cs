using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ValidateStackSequences
{
    public class Solution
    {
        public bool ValidateStackSequences(int[] pushed, int[] popped)
        {
            var stack = new Stack<int>();
            var po = 0;
            var pu = 0;
            while (po < popped.Length || pu < pushed.Length)
                if (stack.Count != 0 && stack.Peek() == popped[po])
                {
                    stack.Pop();
                    po++;
                }
                else if (pu < pushed.Length)
                    stack.Push(pushed[pu++]);
                else
                    return false;
            return true;
        }
    }
}