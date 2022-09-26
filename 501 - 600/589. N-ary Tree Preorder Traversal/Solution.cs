using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace NaryTreePreorderTraversal
{
    public class Solution
    {
        public IList<int> Preorder(NodeN root)
        {
            var res = new List<int>();
            var stack = new Stack<NodeN>();
            if (root != null)
                stack.Push(root);
            
            while(stack.Count > 0)
            {
                var curr = stack.Pop();
                res.Add(curr.val);
                foreach(var ch in curr.children.Reverse())
                    stack.Push(ch);
            }

            return res;
        }
    }
    
    public class Solution_Recursive
    {
        public IList<int> Preorder(NodeN root)
        {
            var res = new List<int>();
            if (root != null)
                Preorder(root, res);

            return res;

            void Preorder(NodeN node, IList<int> res)
            {
                res.Add(node.val);
                foreach (var ch in node.children)
                    Preorder(ch, res);
            }
        }
    }
}