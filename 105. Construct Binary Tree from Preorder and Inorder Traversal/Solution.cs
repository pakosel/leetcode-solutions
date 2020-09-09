using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ConstructBinaryTreeFromPreorderAndInorderTraversal
{
    public class Solution
    {
        private Dictionary<int, int> dict = new Dictionary<int, int>();
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            for(int i=0; i<inorder.Length; i++)
                dict.Add(inorder[i], i);

            return Builder(preorder, inorder, 0, 0, preorder.Length - 1);
        }

        private TreeNode Builder(int[] preorder, int[] inorder, int preorderLeft, int inorderLeft, int inorderRight)
        {
            if(inorderLeft > inorderRight)
                return null;

            int rootVal = preorder[preorderLeft];
            if(inorderLeft == inorderRight)
                return new TreeNode(rootVal);

            TreeNode root = new TreeNode(rootVal);
            int rootIdx = dict[rootVal];
            int inorderCount = rootIdx - inorderLeft;

            root.left = Builder(preorder, inorder, preorderLeft + 1, inorderLeft, rootIdx - 1);
            root.right = Builder(preorder, inorder, preorderLeft + inorderCount + 1, rootIdx + 1, inorderRight);

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