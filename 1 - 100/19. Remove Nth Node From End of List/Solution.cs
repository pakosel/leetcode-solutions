using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace RemoveNthNodeFromEndOfList
{
    //one-pass solution
    public class Solution_2022
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var q = new Queue<ListNode>();
            var curr = head;
            while (curr != null)
            {
                q.Enqueue(curr);
                if (q.Count > n + 1)
                    q.Dequeue();
                curr = curr.next;
            }
            if (q.Count < n + 1)
                return head?.next;
            var prev = q.Dequeue();
            var toDel = q.Dequeue();
            prev.next = toDel.next;

            return head;
        }
    }
    public class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode next = head;
            while (n >= 0 && next != null)
            {
                next = next.next;
                n--;
            }
            if (next == null && n == 0) //test case no.4
                return head.next;

            ListNode prevToRemove = head;
            while (next != null)
            {
                next = next.next;
                prevToRemove = prevToRemove.next;
            }

            prevToRemove.next = prevToRemove.next.next;

            return head;
        }
    }
}