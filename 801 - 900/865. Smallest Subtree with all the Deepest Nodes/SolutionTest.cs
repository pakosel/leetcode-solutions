using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SmallestSubtreeWithDeepestNodes
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1]", "[1]"},
            new object[] {"[3,5,1,6,2,0,8,null,null,7,4]", "[2,7,4]"},
            new object[] {"[0,1,3,null,2]", "[2]"},
            new object[] {"[3,5,1,6,2,0,8,null,null,7,4,9,18]", "[3,5,1,6,2,0,8,null,null,7,4,9,18]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string strArr, string expected)
        {
            var root = TreeNodeHelper.BuildTree(strArr);

            var sol = new Solution();
            var res = sol.SubtreeWithAllDeepest(root);
            var expectedTree = TreeNodeHelper.BuildTree(expected);

            ClassicAssert.IsTrue(TreeNodeHelper.CompareTreeNode(res, expectedTree));
        }
    }
}