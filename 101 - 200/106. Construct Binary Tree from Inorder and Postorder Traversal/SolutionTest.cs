using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ConstructBinaryTreeFromInorderAndPostorderTraversal
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "[-1]", "[-1]", "[-1]" },
            new object[] { "[9,3,15,20,7]", "[9,15,7,20,3]", "[3,9,20,null,null,15,7]" },
            new object[] { "[8,4,2,5,1,9,6,10,3,7]", "[8,4,5,2,9,10,6,7,3,1]", "[1,2,3,4,5,6,7,8,null,null,null,9,10]" },
            new object[] { "[8,4,2,5]", "[8,4,5,2]", "[2,4,5,8]" },
            new object[] { "[4,8,2,5]", "[8,4,5,2]", "[2,4,5,null,8]" },
            new object[] { "[11,9,6,10,3,2,7,1]", "[11,9,10,6,2,1,7,3]", "[3,6,7,9,10,2,1,11]" },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string inorderStr, string postorderStr, string expectedStr)
        {
            var inorder = ArrayHelper.ArrayFromString(inorderStr);
            var postorder = ArrayHelper.ArrayFromString(postorderStr);

            var sol = new Solution();
            var res = sol.BuildTree(inorder, postorder);

            var expected = TreeNodeHelper.BuildTree(expectedStr);
            Assert.IsTrue(TreeNodeHelper.CompareTreeNode(res, expected));
        }
    }
}