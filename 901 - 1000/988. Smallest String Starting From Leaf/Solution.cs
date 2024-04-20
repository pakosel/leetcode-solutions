using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace SmallestStringStartingFromLeaf
{
    public class Solution
    {
        public string SmallestFromLeaf(TreeNode root)
        {
            var res = new SortedSet<string>();
            Visit(root, new StringBuilder());

            return res.Min();

            void Visit(TreeNode node, StringBuilder sb)
            {
                sb.Append((char)('a' + node.val));
                if (node.left == null && node.right == null)
                    res.Add(new string(sb.ToString().Reverse().ToArray()));
                else
                {
                    if (node.left != null)
                        Visit(node.left, sb);
                    if (node.right != null)
                        Visit(node.right, sb);
                }
                sb.Length--;
            }
        }
    }
}