using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

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

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}