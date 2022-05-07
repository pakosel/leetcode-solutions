using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace InsertIntoBinarySearchTree
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[]", 5, "[5]"},
            new object[] {"[4,2,7,1,3]", 5, "[4,2,7,1,3,5]"},
            new object[] {"[40,20,60,10,30,50,70]", 25, "[40,20,60,10,30,50,70,null,null,25]"},
            new object[] {"[4,2,7,1,3,null,null,null,null,null,null]", 5, "[4,2,7,1,3,5]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string treeStr, int val, string expectedStr)
        {
            var root = TreeNodeHelper.BuildTree(treeStr);
            var expected = TreeNodeHelper.BuildTree(expectedStr);

            var sol = new Solution();
            var res = sol.InsertIntoBST(root, val);

            Assert.IsTrue(TreeNodeHelper.CompareTreeNode(res, expected));
        }
    }
}