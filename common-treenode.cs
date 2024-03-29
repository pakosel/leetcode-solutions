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
            var arr = ArrayHelper.ArrayFromString<int?>(arrStr);

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

        public static Node ToNode(TreeNode node)
        {
            if(node == null)
                return null;
            
            return new Node(node.val, ToNode(node.left), ToNode(node.right), null);
        }

        public static bool CompareTreeNode(TreeNode node1, TreeNode node2)
        {
            if(node1 == null && node2 == null)
                return true;
            if(node1 != null && node2 != null)
            {
                return node1.val == node2.val 
                        && CompareTreeNode(node1.left, node2.left) 
                        && CompareTreeNode(node1.right, node2.right);
            }
            
            return false;
        }

        public static string PrintNode(Node node)
        {
            string res = "[";
            while(node != null)
            {
                var n = node;
                while(n != null)
                {
                    res += $"{n.val},";
                    n = n.next;
                }
                res += "#,";
                node = node.left;
            }

            return res.TrimEnd(',') + "]";
        }

        public static TreeNode FindNodeWithVal(TreeNode root, int val)
        {
            if(root == null || root.val == val)
                return root;
            var left = FindNodeWithVal(root.left, val);
            if(left != null)
                return left;
            return FindNodeWithVal(root.right, val);
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

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            TreeNode other = (TreeNode)obj;
            return val == other.val &&
                Equals(left, other.left) &&
                Equals(right, other.right);
        }

        public override int GetHashCode()
        {
            // Custom hash code implementation based on the values of the node and its children.
            int hash = 17;
            hash = hash * 31 + val.GetHashCode();
            hash = hash * 31 + (left != null ? left.GetHashCode() : 0);
            hash = hash * 31 + (right != null ? right.GetHashCode() : 0);

            return hash;
        }

        public static bool operator ==(TreeNode node1, TreeNode node2)
        {
            if (ReferenceEquals(node1, node2))
                return true;

            if (ReferenceEquals(node1, null) || ReferenceEquals(node2, null))
                return false;

            return node1.Equals(node2);
        }

        public static bool operator !=(TreeNode node1, TreeNode node2) => !(node1 == node2);
    }

    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }
}