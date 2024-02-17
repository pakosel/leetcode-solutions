using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace PseudoPalindromicPathsInBinaryTree
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[2,3,1,3,1,null,1]", 2},
            new object[] {"[2,1,1,1,3,null,null,null,null,null,1]", 1},
            new object[] {"[9]", 1},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string treeStr, int expected)
        {
            var root = TreeNodeHelper.BuildTree(treeStr);

            var sol = new Solution();
            var res = sol.PseudoPalindromicPaths(root);

            Assert.That(expected == res);
        }
    }
}