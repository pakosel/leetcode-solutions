using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ConstructBinaryTreeFromPreorderAndInorderTraversal
{
    public class Solution
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            return Builder(preorder, inorder);
        }

        private TreeNode Builder(int[] preorder, int[] inorder)
        {
            int count = preorder.Length;
            if (count == 0)
                return null;
            else if (count == 1)
                return new TreeNode(preorder[0]);

            TreeNode root = new TreeNode(preorder[0]);
            int rootIdx = 0;
            while (inorder[rootIdx] != preorder[0])
                rootIdx++;

            root.left = Builder(preorder[1..(rootIdx + 1)], inorder[0..(rootIdx + 1)]);
            root.right = Builder(preorder[(rootIdx + 1)..], inorder[(rootIdx + 1)..]);

            return root;
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