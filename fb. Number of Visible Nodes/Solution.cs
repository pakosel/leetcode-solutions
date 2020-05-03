using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NumberOfVisibleNodes
{
    public class Solution
    {
        public static int visibleNodes(Node root)
        {
            return GetDepth(root);
        }

        private static int GetDepth(Node node)
        {
            if(node == null)
                return 0;
            else
                return 1 + Math.Max(GetDepth(node.left), GetDepth(node.right));
        }
    }

    public class Node
    {
        public int data;
        public Node left;
        public Node right;
        public Node()
        {
            this.data = 0;
            this.left = null;
            this.right = null;
        }
        public Node(int data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }
    }
}