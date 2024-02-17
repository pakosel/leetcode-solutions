using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace TrimBinarySearchTree
{
    [TestFixture]
    public class MaximumBinaryTree
    {
        private static readonly object[] testCases =
        {
            new object[] { "[1]", 1, 1, "[1]" },
            new object[] { "[1,0,2]", 11, 22, "[]" },
            new object[] { "[1,0,2]", 1, 2, "[1,null,2]" },
            new object[] { "[3,0,4,null,2,null,null,1]", 1, 3, "[3,2,null,1]" },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string tree, int low, int high, string expectedTree)
        {
            var root = TreeNodeHelper.BuildTree(tree);
            var expected = TreeNodeHelper.BuildTree(expectedTree);

            var sol = new Solution();
            var res = sol.TrimBST(root, low, high);

            Assert.That(TreeNodeHelper.CompareTreeNode(res, expected));
        }
    }
}