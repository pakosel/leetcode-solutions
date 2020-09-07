using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace DeleteNodeInBst
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { new TreeNode(3, new TreeNode(2), new TreeNode(5, new TreeNode(4), new TreeNode(10, new TreeNode(8, new TreeNode(7)), new TreeNode(15)))), 5, new TreeNode(3, new TreeNode(2), new TreeNode(7, new TreeNode(4), new TreeNode(10, new TreeNode(8), new TreeNode(15)))) },
            new object[] { new TreeNode(50, new TreeNode(30, null, new TreeNode(40)), new TreeNode(70, new TreeNode(60), new TreeNode(80))), 50, new TreeNode(60, new TreeNode(30, null, new TreeNode(40)), new TreeNode(70, null, new TreeNode(80))) },
            new object[] { new TreeNode(5, new TreeNode(3, new TreeNode(2), new TreeNode(4)), new TreeNode(6, null, new TreeNode(7))), 3, new TreeNode(5, new TreeNode(4, new TreeNode(2)), new TreeNode(6, null, new TreeNode(7))) },
            new object[] { new TreeNode(4, null, new TreeNode(7, new TreeNode(6, new TreeNode(5)), new TreeNode(8, null, new TreeNode(9)))), 7, new TreeNode(4, null, new TreeNode(8, new TreeNode(6, new TreeNode(5)), new TreeNode(9))) },
            new object[] { new TreeNode(3, new TreeNode(2, new TreeNode(1)), new TreeNode(4)), 2, new TreeNode(3, new TreeNode(1), new TreeNode(4)) },
            new object[] { new TreeNode(3, new TreeNode(1, null, new TreeNode(2)), new TreeNode(4)), 1, new TreeNode(3, new TreeNode(2), new TreeNode(4)) },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(TreeNode input, int key, TreeNode expected)
        {
            var sol = new Solution();
            var res = sol.DeleteNode(input, key);

            Assert.IsTrue(CompareTreeNode(res, expected));
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