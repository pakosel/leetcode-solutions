using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ValidateBinarySearchTree
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "[2]", true },
            new object[] { "[2,1,3]", true },
            new object[] { "[5,1,4,null,null,3,6]", false },
            new object[] { "[5,4,6,null,null,3,7]", false },
            new object[] { "[-2147483648,null,2147483647]", true },
            
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string arrStr, bool expected)
        {
            var root = TreeNodeHelper.BuildTree(arrStr);
            var sol = new Solution();
            var res = sol.IsValidBST(root);

            Assert.AreEqual(expected, res);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Stack(string arrStr, bool expected)
        {
            var root = TreeNodeHelper.BuildTree(arrStr);
            var sol = new Solution_Stack();
            var res = sol.IsValidBST(root);

            Assert.AreEqual(expected, res);
        }
    }
}