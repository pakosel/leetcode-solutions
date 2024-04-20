using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace DiameterOfBinaryTree
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,2,3,4,5]", 3},
            new object[] {"[1,2]", 1},
            new object[] {"[1,2,3,4,5,null,null,null,null,6]", 4},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string treeStr, int expected)
        {
            var root = TreeNodeHelper.BuildTree(treeStr);

            var sol = new Solution();
            var res = sol.DiameterOfBinaryTree(root);

            Assert.That(res, Is.EqualTo(expected));
        }
    }
}