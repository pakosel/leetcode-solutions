using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace SwappingNodesInLinkedList
{
    public class Solution
    {
        public ListNode SwapNodes(ListNode head, int k)
        {
            var curr = head;
            var q = new Queue<ListNode>();
            for (int i = 1; i < k; i++)
                curr = curr.next;

            var first = curr;
            while (curr != null)
            {
                q.Enqueue(curr);
                if (q.Count > k)
                    q.Dequeue();
                curr = curr.next;
            }

            ListNode sec = null;
            if (q.Count == k)       //case 1: k <= n/2
                sec = q.Dequeue();
            else
            {   //case 2: k > n/2
                curr = head;
                for (int i = 1; i < q.Count; i++)
                    curr = curr.next;
                sec = curr;
            }

            //swap values only
            (first.val, sec.val) = (sec.val, first.val);

            return head;
        }
    }
}