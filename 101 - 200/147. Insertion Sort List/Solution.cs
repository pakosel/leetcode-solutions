using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace InsertionSortList
{
    public class Solution
    {
        public ListNode InsertionSortList(ListNode head)
        {
            ListNode current = head?.next;
            ListNode prev = head;
            while (current != null)
            {
                var temp = current;
                current = current.next;
                if (temp.val < prev.val)
                {
                    prev.next = current;
                    var newHead = Insert(head, temp);
                    if (newHead != null)
                        head = newHead;
                }
                else
                    prev = temp;
            }

            return head;
        }

        private ListNode Insert(ListNode head, ListNode node)
        {
            if (node.val < head.val)
            {
                node.next = head;
                return node;
            }

            while (head.next != null && head.next.val < node.val)
                head = head.next;
            node.next = head.next;
            head.next = node;

            return null;
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