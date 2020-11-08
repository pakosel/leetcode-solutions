using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace BinaryTreeTilt
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {new TreeNode(1, new TreeNode(2), new TreeNode(3)), 1 },
            new object[] {new TreeNode(4, new TreeNode(2, new TreeNode(3), new TreeNode(5)), new TreeNode(9, null, new TreeNode(7))), 15 },
            new object[] {new TreeNode(21, new TreeNode(7, new TreeNode(1, new TreeNode(3), new TreeNode(3)), new TreeNode(1)), new TreeNode(14, new TreeNode(2), new TreeNode(2))), 9 },
            new object[] {new TreeNode(1, new TreeNode(2, new TreeNode(3, new TreeNode(4, new TreeNode(5))))), 40 },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(TreeNode root, int expected)
        {
            var sol = new Solution();
            var res = sol.FindTilt(root);

            Assert.AreEqual(res, expected);
        }
    }
}