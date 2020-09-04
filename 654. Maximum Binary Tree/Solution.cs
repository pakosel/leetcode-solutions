using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MaximumBinaryTree
{
    public class Solution
    {
        public TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            return BuildMaxNode(nums, 0, nums.Length - 1);
        }

        private TreeNode BuildMaxNode(int[] nums, int left, int right)
        {
            if (left == right)
                return new TreeNode(nums[left]);
            else if (left > right)
                return null;

            int maxIdx = FindMaxIdx(nums, left, right);
            return new TreeNode(nums[maxIdx], BuildMaxNode(nums, left, maxIdx - 1), BuildMaxNode(nums, maxIdx + 1, right));
        }

        private int FindMaxIdx(int[] nums, int left, int right)
        {
            int maxIdx = left;

            for (int i = left; i <= right; i++)
                if (nums[i] > nums[maxIdx])
                    maxIdx = i;
            return maxIdx;
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