using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace LeafSimilarTrees
{
    public class Solution
    {
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            var leafSeq1 = new List<int>(200);
            var leafSeq2 = new List<int>(200);

            GetLeafSequence(root1, leafSeq1);
            GetLeafSequence(root2, leafSeq2);

            return leafSeq1.SequenceEqual(leafSeq2);

            void GetLeafSequence(TreeNode node, IList<int> result)
            {
                if (node.left == null && node.right == null)
                    result.Add(node.val);
                else
                {
                    if (node.left != null)
                        GetLeafSequence(node.left, result);
                    if (node.right != null)
                        GetLeafSequence(node.right, result);
                }
            }
        }
    }
}