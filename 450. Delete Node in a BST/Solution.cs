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
                var minNode = FindAndExtractMin(root.right);
                minNode.left = root.left;
                if (minNode.val == root.right?.val)
                    return root.right;
                minNode.right = root.right;
                return minNode;
            }

            TreeNode parent = FindParentNodeByChildKey(root, key);
            if (parent != null)
            {
                var replaceLeftChild = parent.left?.val == key;
                TreeNode nodeToDel;
                if (replaceLeftChild)
                    nodeToDel = parent.left;
                else
                    nodeToDel = parent.right;

                TreeNode newNode;
                if(nodeToDel.right != null)
                {
                    newNode = FindAndExtractMin(nodeToDel.right);
                    newNode.left = nodeToDel.left;
                    if(newNode.val != nodeToDel.right?.val)
                        newNode.right = nodeToDel.right;
                }
                else
                    newNode = nodeToDel.left;

                if (replaceLeftChild)
                    parent.left = newNode;
                else
                    parent.right = newNode;
            }

            return root;
        }

        private TreeNode FindParentNodeByChildKey(TreeNode node, int key)
        {
            if (node == null)
                return null;
            if (node.left?.val == key || node.right?.val == key)
                return node;
            if (node.val > key)
                return FindParentNodeByChildKey(node.left, key);

            return FindParentNodeByChildKey(node.right, key);
        }

        private TreeNode FindAndExtractMin(TreeNode node)
        {
            TreeNode parent = null;
            while (node?.left != null)
            {
                parent = node;
                node = node.left;
            }
            if (parent != null) //extract and replace right subtree
                parent.left = node.right;

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