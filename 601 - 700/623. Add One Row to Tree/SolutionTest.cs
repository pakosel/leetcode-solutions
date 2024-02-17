using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace AddOneRowToTree
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1]", 1, 1, "[1,1]"},
            new object[] {"[4,2,6,3,1,5]", 7, 3, "[4,2,6,7,7,7,7,3,null,null,1,5]"},
            new object[] {"[4,2,6,3,1,5]", 7, 4, "[4,2,6,3,1,5,null,7,7,7,7,7,7]"},
            new object[] {"[4,2,6,3,1,5]", 1, 2, "[4,1,1,2,null,null,6,3,1,5]"},
            new object[] {"[4,2,null,3,1]", 1, 3, "[4,2,null,1,1,3,null,null,1]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string treeStr, int val, int depth, string expectedStr)
        {
            var root = TreeNodeHelper.BuildTree(treeStr);
            var expected = TreeNodeHelper.BuildTree(expectedStr);

            var sol = new Solution();
            var res = sol.AddOneRow(root, val, depth);

            ClassicAssert.IsTrue(TreeNodeHelper.CompareTreeNode(expected, res));
        }
    }
}