using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace DeleteTheMiddleNodeOfLinkedList
{
    public class Solution
    {
        public ListNode DeleteMiddle(ListNode head)
        {
            int cnt = 1;
            var curr = head;
            while ((curr = curr.next) != null)
                cnt++;
            cnt /= 2;
            if (cnt == 0)
                return null;
            curr = head;
            while (cnt-- > 1)
                curr = curr.next;
            curr.next = curr?.next?.next;
            return head;
        }
    }
}