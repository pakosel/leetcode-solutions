using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace MaximumBinaryTreeII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { new TreeNode(4, new TreeNode(1), new TreeNode(3, new TreeNode(2))), 5, new TreeNode(5, new TreeNode(4, new TreeNode(1), new TreeNode(3, new TreeNode(2)))) },
            new object[] { new TreeNode(5, new TreeNode(2, null, new TreeNode(1)), new TreeNode(4)), 3, new TreeNode(5, new TreeNode(2, null, new TreeNode(1)), new TreeNode(4, null, new TreeNode(3))) },
            new object[] { new TreeNode(5, new TreeNode(2, null, new TreeNode(1)), new TreeNode(3)), 4, new TreeNode(5, new TreeNode(2, null, new TreeNode(1)), new TreeNode(4, new TreeNode(3))) },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(TreeNode input, int val, TreeNode expected)
        {
            var sol = new Solution();
            var res = sol.InsertIntoMaxTree(input, val);

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