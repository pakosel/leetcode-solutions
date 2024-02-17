using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace RecoverBinarySearchTree
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1,3]", "[3,1]"},
            new object[] {"[1,3,null,null,2]", "[3,1,null,null,2]"},
            new object[] {"[3,1,4,null,null,2]", "[2,1,4,null,null,3]"},
            new object[] {"[4,7,6,1,3,5,8,null,null,null,null,null,null,2]", "[4,2,6,1,3,5,8,null,null,null,null,null,null,7]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_GenericStr(string treeStr, string expectedStr)
        {
            var root = TreeNodeHelper.BuildTree(treeStr);
            var expected = TreeNodeHelper.BuildTree(expectedStr);

            var sol = new Solution();
            sol.RecoverTree(root);

            ClassicAssert.IsTrue(TreeNodeHelper.CompareTreeNode(root, expected));
        }
    }
}