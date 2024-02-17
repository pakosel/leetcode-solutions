using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;
using System;

namespace LongestZigZagPathInBinaryTree
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,null,1,1,1,null,null,1,1,null,1,null,null,null,1,null,1]", 3},
            new object[] {"[1,1,1,null,1,null,null,1,1,null,1]", 4},
            new object[] {"[1]", 0},
            new object[] {"[1,null,2]", 1},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string treeStr, int expected)
        {
            var root = TreeNodeHelper.BuildTree(treeStr);

            var sol = new Solution();
            var res = sol.LongestZigZag(root);

            Assert.That(expected == res);
        }
    }
}