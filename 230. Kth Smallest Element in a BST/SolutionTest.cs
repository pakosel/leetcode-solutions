using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace KthSmallestElementInBst
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { new TreeNode(3), 1, 3 },
            new object[] { new TreeNode(3, new TreeNode(1, null, new TreeNode(2)), new TreeNode(4)), 1, 1 },
            new object[] { new TreeNode(3, new TreeNode(1, null, new TreeNode(2)), new TreeNode(4)), 4, 4 },
            new object[] { new TreeNode(5, new TreeNode(3, new TreeNode(2, new TreeNode(1)), new TreeNode(4)), new TreeNode(6)), 3, 3 },
            new object[] { new TreeNode(15, new TreeNode(12, new TreeNode(10, new TreeNode(5, new TreeNode(3, new TreeNode(2), new TreeNode(4)), new TreeNode(7, new TreeNode(6), new TreeNode(8))), new TreeNode(11)), new TreeNode(13, null, new TreeNode(14)))), 5, 6 },
            new object[] { new TreeNode(15, new TreeNode(12, new TreeNode(10, new TreeNode(5, new TreeNode(3, new TreeNode(2), new TreeNode(4)), new TreeNode(7, new TreeNode(6), new TreeNode(8))), new TreeNode(11)), new TreeNode(13, null, new TreeNode(14)))), 6, 7 },
            new object[] { new TreeNode(15, new TreeNode(12, new TreeNode(10, new TreeNode(5, new TreeNode(3, new TreeNode(2), new TreeNode(4)), new TreeNode(7, new TreeNode(6), new TreeNode(8))), new TreeNode(11)), new TreeNode(13, null, new TreeNode(14)))), 7, 8 },
            new object[] { new TreeNode(15, new TreeNode(12, new TreeNode(10, new TreeNode(5, new TreeNode(3, new TreeNode(2), new TreeNode(4)), new TreeNode(7, new TreeNode(6), new TreeNode(8))), new TreeNode(11)), new TreeNode(13, null, new TreeNode(14)))), 8, 10 },
            new object[] { new TreeNode(15, new TreeNode(12, new TreeNode(10, new TreeNode(5, new TreeNode(3, new TreeNode(2), new TreeNode(4)), new TreeNode(7, new TreeNode(6), new TreeNode(8))), new TreeNode(11)), new TreeNode(13, null, new TreeNode(14)))), 9, 11 },
            new object[] { new TreeNode(15, new TreeNode(12, new TreeNode(10, new TreeNode(5, new TreeNode(3, new TreeNode(2), new TreeNode(4)), new TreeNode(7, new TreeNode(6), new TreeNode(8))), new TreeNode(11)), new TreeNode(13, null, new TreeNode(14)))), 11, 13 },
            new object[] { new TreeNode(15, new TreeNode(12, new TreeNode(10, new TreeNode(5, new TreeNode(3, new TreeNode(2), new TreeNode(4)), new TreeNode(7, new TreeNode(6), new TreeNode(8))), new TreeNode(11)), new TreeNode(13, null, new TreeNode(14)))), 13, 15 },
            new object[] { new TreeNode(15, new TreeNode(12, new TreeNode(10, new TreeNode(5, new TreeNode(3, new TreeNode(2), new TreeNode(4)), new TreeNode(7, new TreeNode(6), new TreeNode(8))), new TreeNode(11)), new TreeNode(13, null, new TreeNode(14))), new TreeNode(20, new TreeNode(18))), 14, 18 },
            new object[] { new TreeNode(15, new TreeNode(12, new TreeNode(10, new TreeNode(5, new TreeNode(3, new TreeNode(2), new TreeNode(4)), new TreeNode(7, new TreeNode(6), new TreeNode(8))), new TreeNode(11)), new TreeNode(13, null, new TreeNode(14))), new TreeNode(20, new TreeNode(18))), 15, 20 },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(TreeNode input, int k, int expected)
        {
            var sol = new Solution();
            var res = sol.KthSmallest(input, k);

            Assert.AreEqual(res, expected);
        }
    }
}