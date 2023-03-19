using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace ConvertSortedListToBinarySearchTree
{
    public class Solution
    {
        public TreeNode SortedListToBST(ListNode head)
        {
            var node = head;
            var list = new List<ListNode>();
            while (node != null)
            {
                list.Add(node);
                node = node.next;
            }

            return Tree(1, list.Count);

            TreeNode Tree(int start, int end)
            {
                if (start == end)
                    return new TreeNode(list[start - 1].val);
                if (start > end)
                    return null;
                var mid = start + (end - start) / 2;

                return new TreeNode(list[mid - 1].val, Tree(start, mid - 1), Tree(mid + 1, end));
            }
        }
    }
}