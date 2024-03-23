using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace ReverseLinkedList
{
    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null)
                return head;

            var curr = head.next;
            var prev = head;
            prev.next = null;
            while (curr != null)
            {
                var tmp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = tmp;
            }

            return prev;
        }
    }
}