using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MergeKsortedLists
{
    public class Solution
    {
        Dictionary<int, List<ListNode>> dictAdditionalNodes = new Dictionary<int, List<ListNode>>();
        SortedSet<ListNode> minHeap = new SortedSet<ListNode>(new ListNodeComparer());

        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists.Length == 0)
                return null;

            ListNode res;
            ListNode head;

            foreach (var list in lists)
                TryAddToHeap(list);

            res = minHeap.Min;
            minHeap.Remove(res);
            head = res;
            if (res != null)
            {
                TryAddToHeap(res.next);
                TryAddNodeFromDict(res.val);
            }

            if (res != null && res.next != null)
                minHeap.Add(res.next);

            while (minHeap.Count > 0)
            {
                var min = minHeap.Min;
                minHeap.Remove(min);
                head.next = min;
                if (min.next != null)
                    TryAddToHeap(min.next);
                head = min;

                TryAddNodeFromDict(min.val);
            }

            return res;
        }

        private void TryAddToHeap(ListNode listNode)
        {
            if (listNode == null)
                return;


            if (minHeap.Contains(listNode))
            {
                if (dictAdditionalNodes.ContainsKey(listNode.val))
                    dictAdditionalNodes[listNode.val].Add(listNode);
                else
                    dictAdditionalNodes.Add(listNode.val, new List<ListNode>() { listNode });
            }
            else
                minHeap.Add(listNode);
        }

        private void TryAddNodeFromDict(int val)
        {
            if (dictAdditionalNodes.ContainsKey(val))
            {
                var node = dictAdditionalNodes[val].First();
                if (!minHeap.Contains(node))
                {
                    minHeap.Add(node);
                    dictAdditionalNodes[val].RemoveAt(0);
                    if (dictAdditionalNodes[val].Count == 0)
                        dictAdditionalNodes.Remove(val);
                }
            }
        }
    }

    public class ListNodeComparer : IComparer<ListNode>
    {
        public int Compare(ListNode x, ListNode y) { return x.val.CompareTo(y.val); }
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