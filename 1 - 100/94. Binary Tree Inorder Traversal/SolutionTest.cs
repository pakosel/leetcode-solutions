using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace BinaryTreeInorderTraversal
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { null, new List<int> { } },
            new object[] { new TreeNode(3), new List<int> { 3 } },
            new object[] { new TreeNode(1, null, new TreeNode(2, new TreeNode(3))), new List<int> { 1, 3, 2 } },
            new object[] { new TreeNode(3, new TreeNode(1, null, new TreeNode(2)), new TreeNode(4)), new List<int> { 1, 2, 3, 4} },
            new object[] { new TreeNode(5, new TreeNode(3, new TreeNode(2, new TreeNode(1)), new TreeNode(4)), new TreeNode(6)), new List<int> { 1, 2, 3, 4, 5, 6} },
            new object[] { new TreeNode(15, new TreeNode(12, new TreeNode(10, new TreeNode(5, new TreeNode(3, new TreeNode(2), new TreeNode(4)), new TreeNode(7, new TreeNode(6), new TreeNode(8))), new TreeNode(11)), new TreeNode(13, null, new TreeNode(14)))), new List<int> { 2, 3, 4, 5, 6, 7, 8, 10, 11, 12, 13, 14, 15} },
            new object[] { new TreeNode(15, new TreeNode(12, new TreeNode(10, new TreeNode(5, new TreeNode(3, new TreeNode(2), new TreeNode(4)), new TreeNode(7, new TreeNode(6), new TreeNode(8))), new TreeNode(11)), new TreeNode(13, null, new TreeNode(14))), new TreeNode(20, new TreeNode(18))), new List<int> { 2, 3, 4, 5, 6, 7, 8, 10, 11, 12, 13, 14, 15, 18, 20} },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(TreeNode input, List<int> expected)
        {
            var sol = new Solution();
            var res = sol.InorderTraversal(input);

            CollectionAssert.AreEquivalent(res, expected);
        }
    }
}