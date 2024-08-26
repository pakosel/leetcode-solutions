using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace NaryTreePostorderTraversal
{
    public class Solution
    {
        public IList<int> Postorder(NodeN root)
        {
            var res = new List<int>();

            Dfs(root);

            return res;

            void Dfs(NodeN n)
            {
                if (n == null)
                    return;
                foreach (var child in n.children)
                    Dfs(child);
                res.Add(n.val);
            }
        }
    }
}