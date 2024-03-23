using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace RemoveZeroSumConsecutiveNodesFromLinkedList
{
    public class Solution
    {
        public ListNode RemoveZeroSumSublists(ListNode head)
        {
            const int INF = 1_000_000;
            var arr = ToArray(head);
            for (int i = 0; i < arr.Length; i++)
                Process(i);

            return ToListNode(arr);

            void Process(int pos)
            {
                int i = pos;
                var sum = arr[i];
                while (sum != 0 && i > 0)
                    if (arr[--i] != INF)
                        sum += arr[i];
                if (sum == 0)
                    for (int x = i; x <= pos; x++)
                        arr[x] = INF;
            }

            int[] ToArray(ListNode head)
            {
                var list = new List<int>();
                var curr = head;
                while (curr != null)
                {
                    list.Add(curr.val);
                    curr = curr.next;
                }
                return list.ToArray();
            }

            ListNode ToListNode(int[] arr)
            {
                ListNode res = null, curr = null;
                for (int i = 0; i < arr.Length; i++)
                    if (arr[i] != INF)
                        if (res == null)
                        {
                            res = new ListNode(arr[i]);
                            curr = res;
                        }
                        else
                        {
                            curr.next = new ListNode(arr[i]);
                            curr = curr.next;
                        }
                return res;
            }
        }
    }
}