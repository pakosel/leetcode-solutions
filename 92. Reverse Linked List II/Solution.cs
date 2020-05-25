using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ReverseLinkedListII
{
    public class Solution
    {
        public ListNode ReverseBetween(ListNode head, int m, int n)
        {
            if (n == 1 || n == m)
                return head;

            var parent = head;
            int idx = 1;
            while (idx < m - 1)
            {
                parent = parent.next;
                idx++;
            }

            var curr = parent.next;
            var prev = parent;
            while (idx++ < n)
            {
                var tmp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = tmp;
            }

            if (m == 1)
            {
                parent.next = curr;
                head = prev;
            }
            else
            {
                parent.next.next = curr;
                parent.next = prev;
            }

            return head;
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