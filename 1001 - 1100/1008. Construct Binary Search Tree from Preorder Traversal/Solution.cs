using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace ConstructBinarySearchTreeFromPreorderTraversal
{
    public class Solution
    {
        public TreeNode BstFromPreorder(int[] preorder)
        {
            return Construct(preorder, 0, preorder.Length - 1);
        }

        private TreeNode Construct(int[] preorder, int left, int right)
        {
            var root = new TreeNode(preorder[left]);
            if (left < right)
            {
                var rightStart = preorder[right] > root.val ? right : -1;
                while (rightStart != -1 && preorder[rightStart - 1] > root.val)
                    rightStart--;

                if (rightStart == -1 || left + 1 < rightStart)
                    root.left = Construct(preorder, left + 1, rightStart != -1 ? rightStart - 1 : right);
                if (rightStart != -1)
                    root.right = Construct(preorder, rightStart, right);
            }
            return root;
        }
    }
}