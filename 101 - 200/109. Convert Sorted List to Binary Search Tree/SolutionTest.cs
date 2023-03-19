using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ConvertSortedListToBinarySearchTree
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[]", "[]"},
            new object[] {"[-10,-3,0,5,9]", "[0,-10,5,null,-3,null,9]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string listStr, string expectedStr)
        {
            var head = ListNodeHelper.BuildList(listStr);
            var expected = TreeNodeHelper.BuildTree(expectedStr);

            var sol = new Solution();
            var res = sol.SortedListToBST(head);

            Assert.IsTrue(TreeNodeHelper.CompareTreeNode(expected, res));
        }
    }
}