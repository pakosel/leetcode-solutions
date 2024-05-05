using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace DeleteNodeInLinkedList
{
    public class Solution24
    {
        public void DeleteNode(ListNode node)
        {
            var prev = node;
            var next = node.next;
            while (true)
            {
                prev.val = next.val;
                if (next.next == null)
                {
                    prev.next = null;
                    break;
                }
                (prev, next) = (next, next.next);
            }
        }
    }
    public class Solution
    {
        public void DeleteNode(ListNode node)
        {
            while (node.next.next != null)
            {
                node.val = node.next.val;
                node = node.next;
            }
            node.val = node.next.val;
            node.next = null;
        }
    }
}