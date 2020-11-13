using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace LowestCommonAncestorOfBinaryTree
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[3,5,1,6,2,0,8,null,null,7,4]", 5, 1, 3 },
            new object[] {"[3,5,1,6,2,0,8,null,null,7,4]", 5, 4, 5 },
            new object[] {"[3,5,1,6,2,0,8,null,null,7,4]", 7, 4, 2 },
            new object[] {"[3,5,1,6,2,0,8,null,null,7,4]", 7, 8, 3 },
            new object[] {"[1,2]", 1, 2, 1 },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Stack(string treeStr, int p, int q, int expected)
        {
            var head = TreeNodeHelper.BuildTree(treeStr);

            var sol = new Solution_Stack();
            var res = sol.LowestCommonAncestor(head, p, q);

            Assert.AreEqual(res.val, expected);
        }
    }
}