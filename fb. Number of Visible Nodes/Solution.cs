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
            var nodes = new Stack<KeyValuePair<Node, int>>();
            nodes.Push(new KeyValuePair<Node, int>(root, 1));
            var max = 0;
            while(nodes.Count() > 0)
            {
                var processing = nodes.Pop();
                max = Math.Max(max, processing.Value);
                var leftNode = processing.Key.left;
                var rightNode = processing.Key.right;
                if(leftNode != null)
                    nodes.Push(new KeyValuePair<Node, int>(leftNode, processing.Value + 1));
                if(rightNode != null)
                    nodes.Push(new KeyValuePair<Node, int>(rightNode, processing.Value + 1));
            }

            return max;
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

    public class Solution_naive
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
}