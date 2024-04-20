using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DiameterOfBinaryTree
{
    public class Solution
    {
        public int DiameterOfBinaryTree(TreeNode root)
        {
            var res = 0;
            var deep = new Dictionary<TreeNode, int>();
            Dfs(root);
            return res;

            void Dfs(TreeNode n)
            {
                if (n == null)
                    return;
                Dfs(n.left);
                Dfs(n.right);
                var dL = n.left != null && deep.ContainsKey(n.left) ? deep[n.left] : 0;
                var dR = n.right != null && deep.ContainsKey(n.right) ? deep[n.right] : 0;

                res = Math.Max(res, dL + dR);
                deep[n] = Math.Max(dL, dR) + 1;
            }
        }
    }
}