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
            if (head == null)
                return head;
            var lastOdd = head;
            var firstEven = head.next;
            var even = lastOdd.next;
            while (even != null && even.next != null)
            {
                var temp = even.next?.next;
                lastOdd.next = even.next;
                even.next = temp;
                lastOdd = lastOdd.next;
                lastOdd.next = firstEven;
                even = even.next;
            }
            return head;
        }
    }
}