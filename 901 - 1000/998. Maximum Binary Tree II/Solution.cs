using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MaximumBinaryTreeII
{
    public class Solution
    {
        public TreeNode InsertIntoMaxTree(TreeNode root, int val)
        {
            var nums = FlattenTree(root);
            nums.Add(val);

            return BuildMaxNode(nums.ToArray(), 0, nums.Count - 1);
        }

        private List<int> FlattenTree(TreeNode root)
        {
            var res = new List<int>();
            if (root == null)
                return res;
            res.AddRange(FlattenTree(root.left));
            res.Add(root.val);
            res.AddRange(FlattenTree(root.right));

            return res;
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