using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace PopulatingNextRightPointersEachNode
{
    public class Solution
    {
        public Node Connect(Node root)
        {
            if (root?.left == null)
                return root;

            Queue<Node> leftQueue = new Queue<Node>();
            Queue<Node> rightQueue = new Queue<Node>();

            leftQueue.Enqueue(root.left);
            rightQueue.Enqueue(root.right);
            int queueSize = leftQueue.Count;
            while (leftQueue.Count > 0)
            {
                var lastLeft = ProcessQueue(leftQueue, queueSize);
                lastLeft.next = ProcessQueue(rightQueue, queueSize, true);
                queueSize = leftQueue.Count;
            }

            return root;
        }

        private Node ProcessQueue(Queue<Node> queue, int queueSize, bool returnFirst = false)
        {
            var node = queue.Dequeue();
            var first = node;
            while (--queueSize > 0)
            {
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                }
                var next = queue.Dequeue();
                node.next = next;
                node = next;
            }
            if (node.left != null)
            {
                queue.Enqueue(node.left);
                queue.Enqueue(node.right);
            }
            return returnFirst ? first : node;
        }
    }
}