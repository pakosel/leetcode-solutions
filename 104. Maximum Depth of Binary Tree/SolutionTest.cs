using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace MaximumDepthBinaryTree
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {null, 0 },
            new object[] {new TreeNode(3), 1 },
            new object[] {new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7))), 3 },
            new object[] {new TreeNode(0, new TreeNode(2, new TreeNode(1, new TreeNode(5), new TreeNode(1))), new TreeNode(4, new TreeNode(3, null, new TreeNode(6)), new TreeNode(-1, null, new TreeNode(8, new TreeNode(7))))), 5 },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(TreeNode root, int expected)
        {
            var sol = new Solution();
            var res = sol.MaxDepthRecursive(root);

            Assert.AreEqual(res, expected);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Recursive(TreeNode root, int expected)
        {
            var sol = new Solution();
            var res = sol.MaxDepthRecursive(root);

            Assert.AreEqual(res, expected);
        }
    }
}