using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace DeleteNodeInBst
{

    public class Solution
    {
        public TreeNode DeleteNode(TreeNode root, int key)
        {
            if (root == null)
                return root;

            if (root.val == key)
            {
                if (root.right == null)
                    return root.left;
                var minNode = FindMin(root.right);
                minNode.left = root.left;
                if (minNode.val == root.right?.val)
                    return root.right;
                minNode.right = root.right;
                return minNode;
            }

            TreeNode parent = FindParentNodeByKey(root, key);
            if (parent != null)
            {
                TreeNode nodeToDel;
                if (parent.left?.val == key)
                    nodeToDel = parent.left;
                else
                    nodeToDel = parent.right;

                var newNode = nodeToDel.right != null ? FindMin(nodeToDel.right) : nodeToDel.left;
                if (newNode != null)
                {
                    if (newNode.val == nodeToDel.right?.val)
                        nodeToDel.right = nodeToDel.right?.right;
                    if(newNode.val != nodeToDel.left?.val)
                        newNode.left = nodeToDel.left;
                    newNode.right = nodeToDel.right;
                }

                if (parent.left?.val == key)
                    parent.left = newNode;
                else
                    parent.right = newNode;
            }

            return root;
        }

        private TreeNode FindParentNodeByKey(TreeNode node, int key)
        {
            if (node == null)
                return null;
            if (node.left?.val == key || node.right?.val == key)
                return node;
            if (node.val > key)
                return FindParentNodeByKey(node.left, key);
            return FindParentNodeByKey(node.right, key);
        }

        private TreeNode FindMin(TreeNode node)
        {
            TreeNode parent = null;
            while (node?.left != null)
            {
                parent = node;
                node = node.left;
            }
            if (parent != null)
                parent.left = null;

            return node;
        }
    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}