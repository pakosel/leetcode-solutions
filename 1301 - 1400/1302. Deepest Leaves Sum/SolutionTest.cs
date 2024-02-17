using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace DeepestLeavesSum
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,2,3,4,5,null,6,7,null,null,null,null,8]", 15},
            new object[] {"[6,7,8,2,7,1,3,9,null,1,4,null,null,null,5]", 19},
            new object[] {"[7]", 7},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_BFS(string treeStr, int expected)
        {
            var root = TreeNodeHelper.BuildTree(treeStr);

            var sol = new Solution_BFS();
            var res = sol.DeepestLeavesSum(root);

            Assert.That(expected == res);
        }

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_DFS(string treeStr, int expected)
        {
            var root = TreeNodeHelper.BuildTree(treeStr);

            var sol = new Solution_DFS();
            var res = sol.DeepestLeavesSum(root);

            Assert.That(expected == res);
        }
    }
}