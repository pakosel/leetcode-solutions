using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace NumberOfGoodLeafNodesPairs
{
    public class Solution
    {
        public int CountPairs(TreeNode root, int distance)
        {
            return Visit(root, new int[11]);

            int Visit(TreeNode node, int[] resArr)
            {
                var res = 0;
                if (node.left == null && node.right == null)
                    resArr[0] = 1;
                else
                {
                    var resLeft = new int[11];
                    if (node.left != null)
                        res += Visit(node.left, resLeft);
                    var resRight = new int[11];
                    if (node.right != null)
                        res += Visit(node.right, resRight);
                    for (int i = 1; i < 11; i++)
                        resArr[i] = resLeft[i - 1] + resRight[i - 1];

                    for (int i = 1; i < distance; i++)
                        for (int j = 1; j < distance && i + j <= distance; j++)
                            res += resLeft[i - 1] * resRight[j - 1];
                }
                return res;
            }
        }
    }
}