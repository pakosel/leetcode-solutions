using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace DoubleNumberRepresentedAsLinkedList
{
    public class Solution
    {
        public ListNode DoubleIt(ListNode head)
        {
            var stack = new Stack<ListNode>();
            var curr = head;
            while (curr != null)
            {
                stack.Push(curr);
                curr = curr.next;
            }
            int val = 0;
            while (stack.Any())
            {
                var n = stack.Pop();
                val += 2 * n.val;
                n.val = val % 10;
                val /= 10;
            }
            if (val > 0)
                head = new ListNode(val, head);
            return head;
        }
    }
}