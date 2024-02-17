using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace ConstructBinaryTreeFromPreorderAndInorderTraversal
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { new int[0], new int[0], null },
            new object[] { new int[] { 3,9,20,15,7 }, new int[] { 9,3,15,20,7 }, new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7))) },
            new object[] { new int[] { 3,9,8,20,15,7 }, new int[] { 8,9,3,15,20,7 }, new TreeNode(3, new TreeNode(9, new TreeNode(8)), new TreeNode(20, new TreeNode(15), new TreeNode(7))) },
            new object[] { new int[] { 15,12,10,5,3,2,4,7,6,8,11,13,14,20,18 }, new int[] { 2,3,4,5,6,7,8,10,11,12,13,14,15,18,20 }, new TreeNode(15, new TreeNode(12, new TreeNode(10, new TreeNode(5, new TreeNode(3, new TreeNode(2), new TreeNode(4)), new TreeNode(7, new TreeNode(6), new TreeNode(8))), new TreeNode(11)), new TreeNode(13, null, new TreeNode(14))), new TreeNode(20, new TreeNode(18))) },
            new object[] { new int[] { 15,12,10,5,3,4,7,6,8,11,13,14,20,18 }, new int[] { 3,4,5,6,7,8,10,11,12,13,14,15,18,20 }, new TreeNode(15, new TreeNode(12, new TreeNode(10, new TreeNode(5, new TreeNode(3, null, new TreeNode(4)), new TreeNode(7, new TreeNode(6), new TreeNode(8))), new TreeNode(11)), new TreeNode(13, null, new TreeNode(14))), new TreeNode(20, new TreeNode(18))) },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int[] preorder, int[] inorder, TreeNode expected)
        {
            var sol = new Solution();
            var res = sol.BuildTree(preorder, inorder);

            Assert.That(CompareTreeNode(res, expected));
        }

        private bool CompareTreeNode(TreeNode node1, TreeNode node2)
        {
            if(node1 == null && node2 == null)
                return true;
            if(node1 != null && node2 != null)
            {
                return node1.val == node2.val 
                        && CompareTreeNode(node1.left, node2.left) 
                        && CompareTreeNode(node1.right, node2.right);
            }
            
            return false;
        }
    }
}