using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace AllNodesDistanceKInBinaryTree
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1]", 1, 3, "[]"},
            new object[] {"[3,5,1,6,2,0,8,null,null,7,4]", 5, 2, "[7,4,1]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string strArr, int target, int k, string expectedStr)
        {
            var root = TreeNodeHelper.BuildTree(strArr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.DistanceK(root, new TreeNode(target), k);
            
            CollectionAssert.AreEquivalent(expected, res);
        }
    }
}