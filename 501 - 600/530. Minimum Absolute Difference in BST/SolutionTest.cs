using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MinimumAbsoluteDifferenceInBST
{
    [TestFixture]
    public class MaximumBinaryTree
    {
        private static readonly object[] testCases =
        {
            new object[] {"[4,2,6,1,3]", 1},
            new object[] {"[1,0,48,null,null,12,49]", 1},
            new object[] {"[236,104,701,null,227,null,911]", 9},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string treeStr, int expected)
        {
            var root = TreeNodeHelper.BuildTree(treeStr);

            var sol = new Solution();
            var res = sol.GetMinimumDifference(root);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}