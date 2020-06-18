using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace NextGreaterNodeInLinkedList
{
    public class Solution
    {
        public int[] NextLargerNodes(ListNode head)
        {
            List<int> res = new List<int>();

            var curr = head;

            while (curr != null)
            {
                int nextLarger = NextLarger(curr.next, curr.val);
                res.Add(nextLarger);
                curr = curr.next;
            }

            return res.ToArray();
        }

        private int NextLarger(ListNode node, int val)
        {
            while (node != null)
            {
                if (node.val > val)
                    return node.val;
                node = node.next;
            }

            return 0;
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