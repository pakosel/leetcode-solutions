using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace RemoveNodesFromLinkedList
{
    public class Solution
    {
        public ListNode RemoveNodes(ListNode head)
        {
            var stack = new Stack<ListNode>();
            var curr = head;

            while (curr != null)
            {
                while (stack.Count > 0 && stack.Peek().val < curr.val)
                    stack.Pop();
                if (stack.Count == 0)
                    head = curr;
                else
                    stack.Peek().next = curr;

                stack.Push(curr);
                curr = curr.next;
            }

            return head;
        }
    }
}