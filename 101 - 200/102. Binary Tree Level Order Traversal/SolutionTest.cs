using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace BinaryTreeLevelOrderTraversal
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7))), new List<IList<int>> {new int[] {3}, new int[] {9, 20}, new int[] {15,7}} },
            new object[] {new TreeNode(0, new TreeNode(2, new TreeNode(1, new TreeNode(5), new TreeNode(1))), new TreeNode(4, new TreeNode(3, null, new TreeNode(6)), new TreeNode(-1, null, new TreeNode(8)))), new List<IList<int>> {new int[] {0}, new int[] {2,4}, new int[] {1,3,-1}, new int[] {5,1,6,8}} },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(TreeNode root, IList<IList<int>> expected)
        {
            var sol = new Solution();
            var res = sol.LevelOrder(root);

            Assert.AreEqual(res, expected);
        }
    }
}