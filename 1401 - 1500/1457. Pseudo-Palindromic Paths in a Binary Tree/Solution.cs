using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace PseudoPalindromicPathsInBinaryTree
{
    public class Solution
    {
        public int PseudoPalindromicPaths(TreeNode root)
        {
            var res = 0;

            Dfs(root, new int[10]);

            return res;

            void Dfs(TreeNode node, int[] visited)
            {
                visited[node.val]++;
                if (node.left == null && node.right == null) //leaf - check pseudo-palindrome correctness
                {
                    var hadOdd = false;
                    for (int i = 1; i < 10; i++)
                        if (visited[i] % 2 == 1)
                            if (!hadOdd)
                                hadOdd = true;
                            else
                                return; //for pseudo-palindromic we can have at most ONE odd count
                    res++;
                }
                else
                {
                    if (node.left != null)
                        Dfs(node.left, (int[])visited.Clone());
                    if (node.right != null)
                        Dfs(node.right, (int[])visited.Clone());
                }
            }
        }
    }
}