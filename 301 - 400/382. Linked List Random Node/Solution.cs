using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace LinkedListRandomNode
{
    public class Solution
    {

        int len = int.MaxValue;
        ListNode head;
        Random random;

        public Solution(ListNode head)
        {
            this.head = head;
            random = new Random();
        }

        public int GetRandom()
        {
            return GetElement(random.Next(len));
        }

        private int GetElement(int index)
        {
            int i = 0;
            ListNode node = head;
            
            while (i++ < index && node.next != null)
                node = node.next;

            if (len == int.MaxValue && node.next == null)
                len = i;

            return node.val;
        }
    }
}