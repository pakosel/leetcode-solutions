using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace IncreasingOrderSearchTree
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1]", "[1]"},
            new object[] {"[5,1,7]", "[1,null,5,null,7]"},
            new object[] {"[5,3,6,2,4,null,8,1,null,null,null,7,9]", "[1,null,2,null,3,null,4,null,5,null,6,null,7,null,8,null,9]"},
            new object[] {"[5,4,6,3]", "[3,null,4,null,5,null,6]"},
            new object[] {"[5,4,null,3,null,2]", "[2,null,3,null,4,null,5]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string arrStr, string expected)
        {
            var root = TreeNodeHelper.BuildTree(arrStr);
            
            ClassicAssert.IsNotNull(root);

            var sol = new Solution();
            var res = sol.IncreasingBST(root);
            
            var expectedRoot = TreeNodeHelper.BuildTree(expected);

            ClassicAssert.IsTrue(TreeNodeHelper.CompareTreeNode(res, expectedRoot));
        }
    }
}