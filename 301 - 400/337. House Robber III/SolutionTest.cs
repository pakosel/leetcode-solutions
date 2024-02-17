using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace HouseRobberIII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[]", 0 },
            new object[] {"[3]", 3 },
            new object[] {"[1,2,3]", 5 },
            new object[] {"[3,2,3,null,3,null,1]", 7 },
            new object[] {"[3,4,5,1,3,null,1]", 9 },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Stack(string treeStr, int expected)
        {
            var head = TreeNodeHelper.BuildTree(treeStr);

            var sol = new Solution();
            var res = sol.Rob(head);

            Assert.That(expected == res);
        }
    }
}