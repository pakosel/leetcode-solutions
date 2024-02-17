using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace DeleteLeavesWithGivenValue
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,2,3,2,null,2,4]", 2, "[1,null,3,null,4]"},
            new object[] {"[1,3,3,3,2]", 3, "[1,3,null,null,2]"},
            new object[] {"[1,2,null,2,null,2]", 2, "[1]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string treeStr, int target, string expectedStr)
        {
            var root = TreeNodeHelper.BuildTree(treeStr);
            var expected = TreeNodeHelper.BuildTree(expectedStr);

            var sol = new Solution();
            var res = sol.RemoveLeafNodes(root, target);

            ClassicAssert.IsTrue(TreeNodeHelper.CompareTreeNode(res, expected));
        }
    }
}