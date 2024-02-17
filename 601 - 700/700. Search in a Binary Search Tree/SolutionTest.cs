using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SearchInBinarySearchTree
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1]", 1, "[1]"},
            new object[] {"[1]", 5, "[]"},
            new object[] {"[4,2,7,1,3]", 2, "[2,1,3]"},
            new object[] {"[4,2,7,1,3]", 5, "[]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string treeStr, int val, string expectedStr)
        {
            var root = TreeNodeHelper.BuildTree(treeStr);
            var expected = TreeNodeHelper.BuildTree(expectedStr);

            var sol = new Solution();
            var res = sol.SearchBST(root, val);

            Assert.That(TreeNodeHelper.CompareTreeNode(res, expected));
        }
    }
}