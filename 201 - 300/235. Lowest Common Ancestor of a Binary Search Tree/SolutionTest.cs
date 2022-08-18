using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace LowestCommonAncestorOfBinarySearchTree
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[6,2,8,0,4,7,9,null,null,3,5]", 2, 8, 6 },
            new object[] {"[6,2,8,0,4,7,9,null,null,3,5]", 2, 4, 2 },
            new object[] {"[2,1]", 2, 1, 2 },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string treeStr, int p, int q, int expected)
        {
            var root = TreeNodeHelper.BuildTree(treeStr);

            var sol = new Solution();
            var res = sol.LowestCommonAncestor(root, TreeNodeHelper.FindNodeWithVal(root, p), TreeNodeHelper.FindNodeWithVal(root, q));

            Assert.AreEqual(res.val, expected);
        }
    }
}