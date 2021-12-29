using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;
using LowestCommonAncestorDeepestLeaves;

namespace MiddleOfTheLinkedList
{
    public class Solution
    {
        public ListNode MiddleNode(ListNode head)
        {
            var cnt = 0;
            var curr = head;
            while (curr != null)
            {
                curr = curr.next;
                cnt++;
            }
            cnt /= 2;
            curr = head;
            while (cnt-- > 0)
                curr = curr.next;
            return curr;
        }
    }
}