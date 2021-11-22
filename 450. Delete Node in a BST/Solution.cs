using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace DeleteNodeInBst
{
    public class Solution
    {
        public TreeNode DeleteNode(TreeNode root, int key, TreeNode parent = null)
        {
            if (root == null)
                return parent;
            if (root.val > key)
                DeleteNode(root.left, key, root);
            else if (root.val < key)
                DeleteNode(root.right, key, root);
            else if (root.val == key)
            {
                var newNode = root.right ?? root.left;
                if(newNode?.val > key)  //looking for a new node on the right
                {
                    newNode = FindMin(newNode);

                    newNode.left = root.left;
                    if (newNode.val != root.right?.val)     //case when FindMin(...) returned one of the child nodes
                        newNode.right = root.right;
                }
                if (parent != null)
                {
                    //re-attach the substitute node to parent - depending where the call came from
                    if (parent.right?.val == key)
                        parent.right = newNode;
                    else
                        parent.left = newNode;
                    return parent;
                }
                return newNode;
            }

            return root;
        }

        private TreeNode FindMin(TreeNode node)
        {
            TreeNode parent = null;
            while (node?.left != null)
            {
                parent = node;
                node = node.left;
            }
            if (parent != null)
                //switch any child nodes to parent
                parent.left = node?.right;
            return node;
        }
    }
}