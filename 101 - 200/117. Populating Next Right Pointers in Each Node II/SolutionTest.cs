using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace PopulatingNextRightPointersEachNodeII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[]", "[]"},
            new object[] {"[1]", "[1,#]"},
            new object[] {"[1,2,3]", "[1,#,2,3,#]"},
            new object[] {"[1,1,1]", "[1,#,1,1,#]"},
            new object[] {"[1,2,3,4,5,6,7]", "[1,#,2,3,#,4,5,6,7,#]"},
            new object[] {"[1,2,3,4,5,null,7]", "[1,#,2,3,#,4,5,7,#]"},
            new object[] {"[1,2,3,4,5,null,7,6,null,null,null,null,8]", "[1,#,2,3,#,4,5,7,#,6,8,#]"},
            new object[] {"[1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31]", "[1,#,2,3,#,4,5,6,7,#,8,9,10,11,12,13,14,15,#,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,#]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string treeStr, string expected)
        {
            var root = TreeNodeHelper.ToNode(TreeNodeHelper.BuildTree(treeStr));

            var sol = new Solution();
            var res = sol.Connect(root);

            Assert.That(TreeNodeHelper.PrintNode(res) == expected);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_GenericRecursive(string treeStr, string expected)
        {
            var root = TreeNodeHelper.ToNode(TreeNodeHelper.BuildTree(treeStr));

            var sol = new Solution_Recursive();
            var res = sol.Connect(root);

            Assert.That(TreeNodeHelper.PrintNode(res) == expected);
        }
    }
}