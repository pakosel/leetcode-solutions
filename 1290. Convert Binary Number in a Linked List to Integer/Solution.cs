using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ConvertBinaryNumberInLinkedList
{
    public class Solution
    {
        public int GetDecimalValue(ListNode head)
        {
            int res = 0;
            while (head != null)
            {
                res = res << 1;     //res *= 2;
                res |= head.val;    //res += head.val;
                head = head.next;
            }

            return res;
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