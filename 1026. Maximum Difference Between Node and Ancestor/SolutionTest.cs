using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace MaximumDifferenceBetweenNodeAncestor
{
    [TestFixture]
    public class MaximumDifferenceBetweenNodeAncestor
    {
        private static readonly object[] testCases =
        {
            new object[] {new TreeNode(1, new TreeNode(5)), 4},
            new object[] {new TreeNode(8, new TreeNode(3, new TreeNode(1), new TreeNode(6, new TreeNode(4), new TreeNode(7))), new TreeNode(10, null, new TreeNode(14, new TreeNode(13)))), 7 },
            new object[] {new TreeNode(1, null, new TreeNode(2, null, new TreeNode(0, new TreeNode(3)))), 3},
            new object[] {new TreeNode(8, new TreeNode(3, new TreeNode(2), new TreeNode(6, new TreeNode(8), new TreeNode(1))), new TreeNode(10, null, new TreeNode(14, new TreeNode(13)))), 7 },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(TreeNode root, int expected)
        {
            var sol = new Solution();
            var res = sol.MaxAncestorDiff(root);

            Assert.AreEqual(res, expected);
        }
    }
}