using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace SwapNodesInPairs
{
    public class Solution
    {
        public ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            var res = head.next;
            ListNode parent = null;
            while (head != null)
            {
                SwapNodes(ref parent, ref head);
                head = head.next;
            }
            return res;
        }

        private void SwapNodes(ref ListNode parent, ref ListNode node)
        {
            var nextNode = node.next;
            if (nextNode == null)
                return;

            if (parent != null)
                parent.next = nextNode;
            node.next = nextNode.next;
            nextNode.next = node;
            parent = node;
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