using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace RemoveLinkedListElements
{
    public class Solution
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            while (head != null && head.val == val)
                head = head.next;
            var next = head;
            while (next != null)
                if (next.next?.val == val)
                    next.next = next.next.next;
                else
                    next = next.next;

            return head;
        }
    }
}