using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace FlattenBinaryTreeToLinkedList
{
    public class Solution
    {
        public void Flatten(TreeNode root)
        {
            var q = new Queue<TreeNode>();
            Traverse(root);

            TreeNode prev = null;
            while (q.Count > 0)
            {
                var curr = q.Dequeue();
                curr.left = null;
                curr.right = null;
                if (prev != null)
                    prev.right = curr;

                prev = curr;
            }

            void Traverse(TreeNode node)
            {
                if (node == null)
                    return;
                q.Enqueue(node);
                Traverse(node.left);
                Traverse(node.right);
            }
        }
    }
}