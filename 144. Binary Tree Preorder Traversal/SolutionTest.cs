using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace BinaryTreePreorderTraversal
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            //[1,null,2,3]
            new object[] {new TreeNode(1, null, new TreeNode(2, new TreeNode(3))), new int[] {1,2,3}},
            //[1,4,3,2]
            new object[] {new TreeNode(1, new TreeNode(4, new TreeNode(2)), new TreeNode(3)), new int[] {1,4,2,3}},
            //[7,5,9,4,6,8,10]
            new object[] {new TreeNode(7, new TreeNode(5, new TreeNode(4), new TreeNode(6)), new TreeNode(9, new TreeNode(8), new TreeNode(10))), new int[] {7,5,4,6,9,8,10}},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_PreorderTraversal(TreeNode root, IList<int> expected)
        {
            var sol = new Solution();
            var ret = sol.PreorderTraversal(root);

            Assert.AreEqual(ret, expected);
        }

        private static readonly object[] testCases_bfs =
                {
            //[1,null,2,3]
            new object[] {new TreeNode(1, null, new TreeNode(2, new TreeNode(3))), new int[] {1,2,3}},
            //[1,4,3,2]
            new object[] {new TreeNode(1, new TreeNode(4, new TreeNode(2)), new TreeNode(3)), new int[] {1,4,3,2}},
            //[7,5,9,4,6,8,10]
            new object[] {new TreeNode(7, new TreeNode(5, new TreeNode(4), new TreeNode(6)), new TreeNode(9, new TreeNode(8), new TreeNode(10))), new int[] {7,5,9,4,6,8,10}},
        };

        [Test]
        [TestCaseSource("testCases_bfs")]
        public void Test_BfsTraversal(TreeNode root, IList<int> expected)
        {
            var sol = new Solution();
            var ret = sol.BfsTraversal(root);

            Assert.AreEqual(ret, expected);
        }
    }
}