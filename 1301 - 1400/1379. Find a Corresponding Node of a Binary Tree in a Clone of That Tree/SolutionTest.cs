using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;
using System;

namespace FindCorrespondingNodeBinaryTreeInCloneThatTree
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[7,4,3,null,null,6,19]", 3},
            new object[] {"[7]", 7},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string treeStr, int nodeVal)
        {
            var original = TreeNodeHelper.BuildTree(treeStr);
            var cloned = TreeNodeHelper.BuildTree(treeStr);

            var target = TreeNodeHelper.FindNodeWithVal(original, nodeVal);
            var expected = TreeNodeHelper.FindNodeWithVal(cloned, nodeVal);

            var sol = new Solution();
            var res = sol.GetTargetCopy(original, cloned, target);

            Assert.AreEqual(res, expected);
        }
    }
}