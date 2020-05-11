using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace CousinsInBinaryTree
{
    public class Solution
    {
        public bool IsCousins(TreeNode root, int x, int y)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            Dictionary<int, Tuple<int, int>> parentAndLevel = new Dictionary<int, Tuple<int, int>>();

            queue.Enqueue(root);
            parentAndLevel.Add(root.val, new Tuple<int, int>(-1, 0));
            int firstNodeLevel = -1;
            int firstNodeParent = -1;

            while (queue.Count() > 0)
            {
                var node = queue.Dequeue();
                var nodeLevel = parentAndLevel[node.val].Item2;

                if (node.val == x || node.val == y)
                {
                    if (firstNodeLevel != -1)
                        return firstNodeLevel == nodeLevel && firstNodeParent != parentAndLevel[node.val].Item1;
                    else
                    {
                        firstNodeLevel = nodeLevel;
                        firstNodeParent = parentAndLevel[node.val].Item1;
                    }
                }
                else
                {
                    var tuple = new Tuple<int, int>(node.val, nodeLevel + 1);
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                        parentAndLevel.Add(node.left.val, tuple);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                        parentAndLevel.Add(node.right.val, tuple);
                    }
                }
            }

            return false;
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