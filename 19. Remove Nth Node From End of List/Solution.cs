using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace RemoveNthNodeFromEndOfList
{
    public class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode res = head;
            ListNode next = head;
            while (n >= 0 && next != null)
            {
                next = next.next;
                n--;
            }
            if (next == null && n == 0)
                return head.next;

            ListNode prevToRemove = head;
            while (next != null)
            {
                next = next.next;
                prevToRemove = prevToRemove.next;
            }

            prevToRemove.next = prevToRemove.next.next;

            return res;
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