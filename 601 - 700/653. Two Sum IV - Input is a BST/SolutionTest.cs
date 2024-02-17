using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace TwoSumIVInputIsBST
{
    [TestFixture]
    public class MaximumBinaryTree
    {
        private static readonly object[] testCases =
        {
            new object[] {"[5,3,6,2,4,null,7]", 9, true},
            new object[] {"[5,3,6,2,4,null,7]", 28, false},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string treeStr, int k, bool expected)
        {
            var root = TreeNodeHelper.BuildTree(treeStr);

            var sol = new Solution();
            var res = sol.FindTarget(root, k);

            Assert.That(expected == res);
        }
    }
}