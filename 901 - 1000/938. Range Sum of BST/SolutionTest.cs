using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace RangeSumOfBst
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1]", 7, 15, 0 },
            new object[] {"[10]", 7, 15, 10 },
            new object[] {"[10,5,15,3,7,null,18]", 7, 15, 32 },
            new object[] {"[10,5,15,3,7,13,18,1,null,6]", 6, 10, 23 },
            new object[] {"[18,9,27,6,15,24,30,3,null,12,null,21]", 18, 24, 63 },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Stack(string treeStr, int low, int high, int expected)
        {
            var head = TreeNodeHelper.BuildTree(treeStr);

            var sol = new Solution();
            var res = sol.RangeSumBST(head, low, high);

            Assert.That(expected == res);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Recursive(string treeStr, int low, int high, int expected)
        {
            var head = TreeNodeHelper.BuildTree(treeStr);

            var sol = new Solution_Recursive();
            var res = sol.RangeSumBST(head, low, high);

            Assert.That(expected == res);
        }
    }
}