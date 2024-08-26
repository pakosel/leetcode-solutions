using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MergeNodesInBetweenZeros
{
    public class Solution
    {
        public ListNode MergeNodes(ListNode head)
        {
            var curr = head.next;
            var next = curr.next;
            while (next != null)
            {
                if (next.val != 0)
                {
                    curr.val += next.val;
                    next = next.next;
                }
                else
                {
                    curr.next = next.next;
                    curr = curr.next;
                    next = curr?.next;
                }
            }
            return head.next;
        }
    }
}