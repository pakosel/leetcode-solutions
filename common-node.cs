using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Common
{
    public class NodeHelper
    {
        public static NodeN BuildTree(string arrStr)
        {
            var arr = ArrayHelper.ArrayFromString<int?>(arrStr);

            NodeN head = null;

            if (arr.Length > 0)
            {
                head = NewNodeN(arr[0]);

                Queue<NodeN> parents = new Queue<NodeN>();
                parents.Enqueue(head);

                int i = 1;
                NodeN parent = null;
                while (i < arr.Length)
                {
                    var node = NewNodeN(arr[i]);

                    if (node == null)
                        parent = parents.Dequeue();
                    else
                    {
                        parent.children.Add(node);

                        parents.Enqueue(node);
                    }

                    i++;
                }
            }

            return head;
        }

        private static NodeN NewNodeN(int? val) => val != null ? new NodeN(val ?? 0) { children = new List<NodeN>() } : null;
    }

    public class NodeN
    {
        public int val;
        public IList<NodeN> children;

        public NodeN() { }

        public NodeN(int _val)
        {
            val = _val;
        }

        public NodeN(int _val, IList<NodeN> _children)
        {
            val = _val;
            children = _children;
        }
    }
}