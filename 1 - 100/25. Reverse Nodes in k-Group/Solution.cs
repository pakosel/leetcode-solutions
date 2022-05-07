using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ReverseNodesInGroup
{
    public class Solution
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            if (head == null || k == 1)
                return head;
                
            var headTail = ReverseSublist(head, k);
            var res = headTail.Item1;

            while (headTail.Item2 != null && headTail.Item2.next != null)
            {
                var newHeadTail = ReverseSublist(headTail.Item2.next, k);
                headTail.Item2.next = newHeadTail.Item1;
                headTail = newHeadTail;
            }

            return res;
        }

        //returning Tuple<newHead, newTail>
        private (ListNode, ListNode) ReverseSublist(ListNode head, int count)
        {
            if (head == null)
                return (null, null);
            int idx = count;
            var testLen = head.next;
            while (testLen != null && idx-- > 1)
                testLen = testLen.next;
            if (idx > 1)
                return (head, null);

            var newTail = head;
            var curr = head.next;
            var prev = head;
            while (curr != null && count-- > 1)
            {
                var tmp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = tmp;
            }
            newTail.next = curr;

            return (prev, newTail);
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