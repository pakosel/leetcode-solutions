using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace CountGoodNodesInBinaryTree
{
    public class Solution
    {
        public int GoodNodes(TreeNode root)
        {
            var res = 0;
            Visit(root, root.val);

            return res;

            void Visit(TreeNode node, int max)
            {
                if (node == null)
                    return;
                if (node.val >= max)
                    res++;
                Visit(node.left, Math.Max(max, node.val));
                Visit(node.right, Math.Max(max, node.val));
            }
        }
    }
}