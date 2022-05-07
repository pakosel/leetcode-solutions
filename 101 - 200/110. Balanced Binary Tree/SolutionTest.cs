using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace BalancedBinaryTree
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "[]", true },
            new object[] { "[3,9,20,null,null,15,7]", true },
            new object[] { "[1,2,2,3,3,null,null,4,4]", false },
            new object[] { "[[1,2,2,3,3,5,5,null,null,4,4,6]]", true },
            new object[] { "[1,2,2,3,3,5,5,null,null,4,4,6,null,null,null,null,null,null,null,8]", false },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string strArray, bool expected)
        {
            var root = TreeNodeHelper.BuildTree(strArray);

            var sol = new Solution();
            var res = sol.IsBalanced(root);

            Assert.AreEqual(res, expected);
        }
    }
}