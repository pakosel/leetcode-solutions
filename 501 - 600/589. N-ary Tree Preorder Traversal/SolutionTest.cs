using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace NaryTreePreorderTraversal
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1,null,3,2,4,null,5,6]", "[1,3,5,6,2,4]"},
            new object[] {"[1,null,2,3,4,5,null,null,6,7,null,8,null,9,10,null,null,11,null,12,null,13,null,null,14]", "[1,2,3,6,7,11,14,4,8,12,5,9,13,10]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string treeStr, string expectedStr)
        {
            var root = NodeHelper.BuildTree(treeStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.Preorder(root);

            Assert.AreEqual(expected, res);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic_Recursive(string treeStr, string expectedStr)
        {
            var root = NodeHelper.BuildTree(treeStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution_Recursive();
            var res = sol.Preorder(root);

            Assert.AreEqual(expected, res);
        }
    }
}