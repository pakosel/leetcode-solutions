using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace InvertBinaryTree
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[4,2,7,1,3,6,9]", "[4,7,2,9,6,3,1]"},
            new object[] {"[2,1,3]", "[2,3,1]"},
            new object[] {"[]", "[]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string treeStr, string expectedStr)
        {
            var tree = TreeNodeHelper.BuildTree(treeStr);

            var sol = new Solution();
            var res = sol.InvertTree(tree);
            var expected = TreeNodeHelper.BuildTree(expectedStr);

            ClassicAssert.IsTrue(TreeNodeHelper.CompareTreeNode(expected, res));
        }
    }
}