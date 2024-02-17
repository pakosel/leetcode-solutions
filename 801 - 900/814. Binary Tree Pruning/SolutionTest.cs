using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace BinaryTreePruning
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1,null,0,0,1]", "[1,null,0,null,1]"},
            new object[] {"[1,0,1,0,0,0,1]", "[1,null,1,null,1]"},
            new object[] {"[1,1,0,1,1,0,1,0]", "[1,1,0,1,1,null,1]"},
            new object[] {"[1,null,0,0,1,1]", "[1,null,0,0,1,1]"},
            new object[] {"[1,null,0,0,1,null,1]", "[1,null,0,0,1,null,1]"},
            new object[] {"[1]", "[1]"},
            new object[] {"[0]", "[]"},
            new object[] {"[0,1]", "[0,1]"},
            new object[] {"[0,null,1]", "[0,null,1]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string treeStr, string expectedStr)
        {
            var root = TreeNodeHelper.BuildTree(treeStr);
            var expected = TreeNodeHelper.BuildTree(expectedStr);

            var sol = new Solution();
            var res = sol.PruneTree(root);

            Assert.That(TreeNodeHelper.CompareTreeNode(expected, res));
        }
    }
}