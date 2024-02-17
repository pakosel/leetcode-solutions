using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace CousinsInBinaryTree
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {new TreeNode(1, new TreeNode(2, new TreeNode(4)), new TreeNode(3)), 4, 3, false},
            new object[] {new TreeNode(1, new TreeNode(2, null, new TreeNode(4)), new TreeNode(3, null, new TreeNode(5))), 5, 4, true},
            new object[] {new TreeNode(1, new TreeNode(2, null, new TreeNode(4)), new TreeNode(3)), 2, 3, false},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(TreeNode root, int x, int y, bool expected)
        {
            var sol = new Solution();
            var res = sol.IsCousins(root, x, y);

            Assert.That(expected == res);
        }
    }
}