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
            int[] visited = new int[10];

            Dfs(root);

            return res;

            void Dfs(TreeNode node)
            {
                visited[node.val]++;
                if (node.left == null && node.right == null) //leaf - check semi-palindrome correctness
                    res += CheckPalindromic(visited) ? 1 : 0;
                if (node.left != null)
                    Dfs(node.left);
                if (node.right != null)
                    Dfs(node.right);
                visited[node.val]--;
            }

            static bool CheckPalindromic(int[] visited)
            {
                var hadOdd = false;
                for (int i = 1; i < visited.Length; i++)
                    if (visited[i] % 2 == 1)
                        if (!hadOdd)
                            hadOdd = true;
                        else
                            return false;
                return true;
            }
        }
    }
}