using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MinimumDepthOfBinaryTree
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[]", 0},
            new object[] {"[3,9,20,null,null,15,7]", 2},
            new object[] {"[2,null,3,null,4,null,5,null,6]", 5},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string treeStr, int expected)
        {
            var root = TreeNodeHelper.BuildTree(treeStr);

            var sol = new Solution();
            var res = sol.MinDepth(root);

            Assert.That(expected == res);
        }
    }
}