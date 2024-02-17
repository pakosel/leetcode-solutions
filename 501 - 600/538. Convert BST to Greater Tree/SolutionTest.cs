using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ConvertBstToGreaterTree
{
    [TestFixture]
    public class MaximumBinaryTree
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1]", "[1]"},
            new object[] {"[4,1,6,0,2,5,7,null,null,null,3,null,null,null,8]", "[30,36,21,36,35,26,15,null,null,null,33,null,null,null,8]"},
            new object[] {"[0,null,1]", "[1,null,1]"},
            new object[] {"[4,1,null,0]", "[4,5,null,5]"},
            new object[] {"[4,null,5,null,6]", "[15,null,11,null,6]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string tree, string expectedTree)
        {
            var root = TreeNodeHelper.BuildTree(tree);
            var expected = TreeNodeHelper.BuildTree(expectedTree);

            var sol = new Solution();
            var res = sol.ConvertBST(root);

            ClassicAssert.IsTrue(TreeNodeHelper.CompareTreeNode(res, expected));
        }
    }
}