using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ConstructBinarySearchTreeFromPreorderTraversal
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[8,5,1,7,10,12]", "[8,5,10,1,7,null,12]"},
            new object[] {"[1,3]", "[1,null,3]"},
            new object[] {"[1]", "[1]"},
            new object[] {"[8,5,1,7]", "[8,5,null,1,7]"},
            new object[] {"[8,10,12]", "[8,null,10,null,12]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string preorderStr, string expectedStr)
        {
            var preorder = ArrayHelper.ArrayFromString<int>(preorderStr);
            var expected = TreeNodeHelper.BuildTree(expectedStr);

            var sol = new Solution();
            var res = sol.BstFromPreorder(preorder);

            Assert.That(CompareTreeNode(res, expected));
        }

        private bool CompareTreeNode(TreeNode node1, TreeNode node2)
        {
            if(node1 == null && node2 == null)
                return true;
            if(node1 != null && node2 != null)
            {
                return node1.val == node2.val 
                        && CompareTreeNode(node1.left, node2.left) 
                        && CompareTreeNode(node1.right, node2.right);
            }
            
            return false;
        }
    }
}