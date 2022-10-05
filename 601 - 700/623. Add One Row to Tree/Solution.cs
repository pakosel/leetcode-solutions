using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace AddOneRowToTree
{
    public class Solution
    {
        public TreeNode AddOneRow(TreeNode root, int val, int depth)
        {
            if (depth == 1)
                return new TreeNode(val, root);
            var q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (--depth > 1)
            {
                var cnt = q.Count;
                while (cnt-- > 0)
                {
                    var node = q.Dequeue();
                    if (node.left != null) q.Enqueue(node.left);
                    if (node.right != null) q.Enqueue(node.right);
                }
            }
            while (q.Count > 0)
            {
                var node = q.Dequeue();
                node.left = new TreeNode(val, node.left);
                node.right = new TreeNode(val, null, node.right);
            }
            return root;
        }
    }
}