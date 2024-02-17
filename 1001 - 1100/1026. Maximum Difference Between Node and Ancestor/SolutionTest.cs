using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaximumDifferenceBetweenNodeAncestor
{
    [TestFixture]
    public class MaximumDifferenceBetweenNodeAncestor
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1,1]", 0},
            new object[] {"[1,5]", 4},
            new object[] {"[8,3,10,1,6,null,14,null,null,4,7,13]", 7},
            new object[] {"[1,null,2,null,0,3]", 3},
            new object[] {"[8,3,10,2,6,null,14,null,null,8,1,13]", 7},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string nodeStr, int expected)
        {
            var node = TreeNodeHelper.BuildTree(nodeStr);

            var sol = new Solution();
            var res = sol.MaxAncestorDiff(node);

            Assert.That(expected == res);
        }
    }
}