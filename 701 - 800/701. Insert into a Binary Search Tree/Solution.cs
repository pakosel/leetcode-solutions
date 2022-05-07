using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace InsertIntoBinarySearchTree
{
    public class Solution
    {
        public TreeNode InsertIntoBST(TreeNode root, int val)
        {
            return Insert(root, val);
        }

        private TreeNode Insert(TreeNode node, int val)
        {
            if (node == null)
                return new TreeNode(val);
            if (node.val > val)
                node.left = Insert(node.left, val);
            else
                node.right = Insert(node.right, val);
            return node;
        }
    }
}