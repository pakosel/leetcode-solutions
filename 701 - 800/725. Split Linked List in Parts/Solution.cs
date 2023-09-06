using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace SplitLinkedListInParts
{
    public class Solution_2023
    {
        public ListNode[] SplitListToParts(ListNode head, int k)
        {
            var len = 0;
            var curr = head;
            while (curr != null)
            {
                len++;
                curr = curr.next;
            }
            var partLen = len / k;
            var mod = len % k;

            var res = new ListNode[k];
            var currLen = 1;
            var i = 0;
            curr = head;
            res[i] = curr;
            while (curr != null && i < k - 1)
            {
                if (currLen > partLen || (currLen == partLen && mod <= 0))
                {
                    (curr, curr.next) = (curr.next, null);
                    res[++i] = curr;
                    currLen = 1;
                    mod--;
                }
                else
                {
                    curr = curr.next;
                    currLen++;
                }
            }
            return res;
        }
    }
    
    public class Solution
    {
        public ListNode[] SplitListToParts(ListNode head, int k)
        {
            var len = 0;
            var curr = head;
            while (curr != null)
            {
                len++;
                curr = curr.next;
            }

            var sizes = new int[k];
            Array.Fill(sizes, len / k);
            var rem = len % k;

            int pos = 0;
            while (rem-- > 0)
                sizes[pos++]++;

            var res = new ListNode[k];
            curr = head;
            pos = 0;
            res[pos] = curr;
            while (curr != null && pos < k - 1)
                if (--sizes[pos] == 0)
                {
                    res[++pos] = curr.next;
                    (curr, curr.next) = (curr.next, null);
                }
                else
                    curr = curr.next;

            return res;
        }
    }
}