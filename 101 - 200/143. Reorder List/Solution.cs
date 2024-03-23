using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace ReorderList
{
    public class Solution
    {
        public void ReorderList(ListNode head)
        {
            var stack = new Stack<ListNode>();
            var curr = head;
            while (curr != null)
            {
                stack.Push(curr);
                curr = curr.next;
            }

            curr = head;
            var todo = stack.Count / 2;
            while (todo-- > 0)
            {
                var pop = stack.Pop();
                (pop.next, curr.next) = (curr.next, pop);
                curr = curr.next.next;
            }
            curr.next = null;
        }
    }
}