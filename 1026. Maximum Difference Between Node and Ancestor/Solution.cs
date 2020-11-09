using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MaximumDifferenceBetweenNodeAncestor
{
    public class Solution
    {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        SortedSet<int> heap = new SortedSet<int>();
        Dictionary<int, int> nodeDict = new Dictionary<int, int>();
        int maxDiff = 0;

        public int MaxAncestorDiff(TreeNode root)
        {
            TraverseLeft(root);
            while (stack.Count > 0)
            {
                var node = stack.Peek();
                if (node.right == null)
                {
                    int minmax = Math.Max(Math.Abs(heap.Min - node.val), Math.Abs(heap.Max - node.val));
                    Pop();
                    maxDiff = Math.Max(maxDiff, minmax);
                }
                else
                {
                    TraverseLeft(node.right);
                    node.right = null;
                }
            }

            return maxDiff;
        }

        private void TraverseLeft(TreeNode node)
        {
            while (node != null)
            {
                stack.Push(node);
                if (nodeDict.ContainsKey(node.val))
                    nodeDict[node.val]++;
                else
                {
                    heap.Add(node.val);
                    nodeDict.Add(node.val, 1);
                }
                node = node.left;
            }
        }

        private TreeNode Pop()
        {
            var res = stack.Pop();
            if (nodeDict[res.val] == 1)
            {
                nodeDict.Remove(res.val);
                heap.Remove(res.val);
            }
            else
                nodeDict[res.val]--;

            return res;
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