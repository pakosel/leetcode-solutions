using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Common
{
    public class TreeNodeHelper
    {
        public static TreeNode BuildTree(string arrStr)
        {
            var arr = ArrayHelper.ParseArrayForTreeNode(arrStr);

            TreeNode head = null;

            if(arr.Length > 0)
            {
                head = NewTreeNode(arr[0]);

                Queue<TreeNode> parents = new Queue<TreeNode>();
                parents.Enqueue(head);

                int i = 1;
                TreeNode parent = null;
                while(i < arr.Length)
                {
                    var node = NewTreeNode(arr[i]);

                    if(parent == null)
                    {
                        parent = parents.Dequeue();
                        parent.left = node;
                    }
                    else
                    {
                        parent.right = node;
                        parent = null;
                    }

                    if(node != null)
                        parents.Enqueue(node);
                    i++;
                }
            }

            return head;
        }

        private static TreeNode NewTreeNode(int? val) => val != null ? new TreeNode(val ?? 0) : null;
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