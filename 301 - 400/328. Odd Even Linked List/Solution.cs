using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace OddEvenLinkedList
{
    public class Solution
    {
        public ListNode OddEvenList(ListNode head)
        {
            var queue = new Queue<int>();
            var node = head;
            var isEven = true;
            while (node?.next != null)
            {
                if (isEven)
                {
                    queue.Enqueue(node.next.val);
                    node.next = node.next.next;
                }
                else
                {
                    if (node.next != null)
                        node = node.next;
                    else
                        break;
                }
                isEven = !isEven;
            }
            while (queue.Count > 0)
            {
                node.next = new ListNode(queue.Dequeue());
                node = node.next;
            }
            return head;
        }
    }
}