using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CountGoodNodesInBinaryTree
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1]", 1},
            new object[] {"[3,1,4,3,null,1,5]", 4},
            new object[] {"[3,3,null,4,2]", 3},
            new object[] {"[1,2,3]", 3},
            new object[] {"[3,2,1]", 1},
            new object[] {"[9,8,7,6,5,4,3,null,11,null,null,12]", 3},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string treeStr, int expected)
        {
            var root = TreeNodeHelper.BuildTree(treeStr);

            var sol = new Solution();
            var res = sol.GoodNodes(root);

            Assert.That(expected == res);
        }
    }
}