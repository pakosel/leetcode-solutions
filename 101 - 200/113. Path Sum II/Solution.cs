using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace PathSumII
{
    public class Solution_2022
    {
        public IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {
            var res = new List<IList<int>>();
            if (root != null)
                Dfs(new List<int>(5000), root);

            return res;

            void Dfs(List<int> visited, TreeNode root)
            {
                visited.Add(root.val);
                if (root.left == null && root.right == null)
                {
                    if (visited.Sum() == targetSum)
                        res.Add(visited);
                }
                else
                {
                    if (root.left != null)
                        Dfs(new List<int>(visited), root.left);
                    if (root.right != null)
                        Dfs(new List<int>(visited), root.right);
                }
            }
        }
    }
    public class Solution
    {
        public IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {
            return GetList(root, targetSum, new List<int>());
        }

        private IList<IList<int>> GetList(TreeNode node, int target, List<int> list)
        {
            var res = new List<IList<int>>();
            if (node == null)
                return res;

            if (node.left == null && node.right == null && node.val == target)
            {
                var newList = new List<int>(list);
                newList.Add(node.val);
                res.Add(newList);
            }
            else
            {
                list.Add(node.val);

                res.AddRange(GetList(node.left, target - node.val, new List<int>(list)));
                res.AddRange(GetList(node.right, target - node.val, new List<int>(list)));

            }
            return res;
        }
    }
}