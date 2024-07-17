using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace DeleteNodesAndReturnForest
{
    public class Solution
    {
        public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete)
        {
            var set = new HashSet<int>(to_delete);
            var res = new List<TreeNode>();

            if (root != null && !set.Contains(root.val))
                res.Add(root);

            Visit(root);

            return res;

            void Visit(TreeNode node)
            {
                if (node == null)
                    return;
                if (set.Contains(node.val))
                {
                    if (node.left != null && !set.Contains(node.left.val))
                        res.Add(node.left);
                    if (node.right != null && !set.Contains(node.right.val))
                        res.Add(node.right);
                }
                Visit(node.left);
                Visit(node.right);
                if (node.left != null && set.Contains(node.left.val))
                    node.left = null;
                if (node.right != null && set.Contains(node.right.val))
                    node.right = null;
            }
        }
    }
}