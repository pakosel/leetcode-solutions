using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CheckCompletenessOfBinaryTree
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1,2,3,4,5,6]", true},
            new object[] {"[1,2,3,4,5,null,7]", false},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string treeStr, bool expected)
        {
            var root = TreeNodeHelper.BuildTree(treeStr);

            var sol = new Solution();
            var res = sol.IsCompleteTree(root);

            Assert.AreEqual(expected, res);
        }
    }
}