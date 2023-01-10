using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SameTree
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[]", "[]", true },
            new object[] {"[1]", "[1]", true },
            new object[] {"[]", "[1]", false },
            new object[] {"[1]", "[]", false },
            new object[] {"[1,2,3]", "[1,2,3]", true },
            new object[] {"[1,2]", "[1,null,2]", false },
            new object[] {"[1,2,1]", "[1,1,2]", false },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string pStr, string qStr, bool expected)
        {
            var p = TreeNodeHelper.BuildTree(pStr);
            var q = TreeNodeHelper.BuildTree(qStr);

            var sol = new Solution();
            var res = sol.IsSameTree(p, q);

            Assert.AreEqual(expected, res);
        }
    }
}