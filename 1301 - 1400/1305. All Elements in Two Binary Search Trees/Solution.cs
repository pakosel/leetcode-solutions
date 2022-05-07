using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace AllElementsInTwoBinarySearchTrees
{
    public class Solution
    {
        public IList<int> GetAllElements(TreeNode root1, TreeNode root2)
        {
            var list1 = new List<int>();
            var list2 = new List<int>();
            BstToList(root1, list1);
            BstToList(root2, list2);

            list1.AddRange(list2);
            return list1.OrderBy(_ => _).ToList();
        }

        private void BstToList(TreeNode root, List<int> list)
        {
            if (root == null)
                return;
            BstToList(root.left, list);
            list.Add(root.val);
            BstToList(root.right, list);
        }
    }
}