using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace ValidateBinaryTreeNodes
{
    public class Solution
    {
        public bool ValidateBinaryTreeNodes(int n, int[] leftChild, int[] rightChild)
        {
            //build reverse graph in order to find a root
            var graphRev = new int?[n];
            for (int i = 0; i < n; i++)
            {
                if (!AddTarget(i, leftChild[i]))
                    return false;
                if (!AddTarget(i, rightChild[i]))
                    return false;
            }

            var q = new Queue<int>();
            //find root
            for (int i = 0; i < n; i++)
                if (!graphRev[i].HasValue)
                    if (q.Count > 0)
                        return false;   //more than 1 root
                    else
                        q.Enqueue(i);

            if (q.Count == 0)
                return false;   //no root

            //bfs from root to leafs
            var visited = new HashSet<int>();
            while (q.Count > 0)
            {
                var curr = q.Dequeue();
                if (visited.Contains(curr))
                    return false;
                visited.Add(curr);
                if (leftChild[curr] != -1)
                    q.Enqueue(leftChild[curr]);
                if (rightChild[curr] != -1)
                    q.Enqueue(rightChild[curr]);
            }

            return visited.Count == n;

            bool AddTarget(int i, int tgt)
            {
                if (tgt != -1)
                    if (graphRev[tgt].HasValue)
                        return false;   //two paths to the same node
                    else
                        graphRev[tgt] = i;
                return true;
            }
        }
    }
}