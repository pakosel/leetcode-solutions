using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace AddTwoNumbers
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var res = new ListNode(0);
            var curr = res;
            var carry = 0;
            while (l1 != null || l2 != null)
            {
                var x = l1?.val ?? 0;
                var y = l2?.val ?? 0;
                var sum = x + y + carry;
                curr.next = new ListNode(sum % 10);
                carry = sum / 10;
                curr = curr.next;
                l1 = l1?.next;
                l2 = l2?.next;
            }
            while (carry != 0)
            {
                curr.next = new ListNode(carry % 10);
                carry /= 10;
            }
            return res.next;
        }
    }
}