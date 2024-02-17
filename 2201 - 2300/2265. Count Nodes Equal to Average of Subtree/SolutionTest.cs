using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CountNodesEqualToAverageOfSubtree
{
    [TestFixture]
    public class MaximumBinaryTree
    {
        private static readonly object[] testCases =
        {
            new object[] {"[4,8,5,0,1,null,6]", 5},
            new object[] {"[1]", 1},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string tree, int expected)
        {
            var root = TreeNodeHelper.BuildTree(tree);

            var sol = new Solution();
            var res = sol.AverageOfSubtree(root);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}