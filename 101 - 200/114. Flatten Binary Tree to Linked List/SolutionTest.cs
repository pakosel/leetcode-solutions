using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FlattenBinaryTreeToLinkedList
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "[]", "[]" },
            new object[] { "[0]", "[0]" },
            new object[] { "[1,2,5,3,4,null,6]", "[1,null,2,null,3,null,4,null,5,null,6]" },
            new object[] { "[1,2,5,3,4,null,6,null,null,7,8,null,9]", "[1,null,2,null,3,null,4,null,7,null,8,null,5,null,6,null,9]" },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string treeStr, string expectedStr)
        {
            var root = TreeNodeHelper.BuildTree(treeStr);
            var expected = TreeNodeHelper.BuildTree(expectedStr);

            var sol = new Solution();
            sol.Flatten(root);

            Assert.That(TreeNodeHelper.CompareTreeNode(root, expected));
        }
    }
}