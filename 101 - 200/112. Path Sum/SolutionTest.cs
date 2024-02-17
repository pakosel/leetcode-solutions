using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace PathSum
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "[]", 0, false},
            new object[] { "[1,2,3]", 5, false},
            new object[] { "[5,4,8,11,null,13,4,7,2,null,null,null,1]", 22, true},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string treeStr, int targetSum, bool expected)
        {
            var root = TreeNodeHelper.BuildTree(treeStr);

            var sol = new Solution();
            var res = sol.HasPathSum(root, targetSum);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}