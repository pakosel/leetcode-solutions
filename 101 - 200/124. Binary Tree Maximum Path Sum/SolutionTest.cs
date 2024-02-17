using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace BinaryTreeMaximumPathSum
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1,2,3]", 6},
            new object[] {"[-10,9,20,null,null,15,7]", 42},
            new object[] {"[-10,9,20,null,null,15,7,-20,20,30,-35]", 92},
            new object[] {"[-2,-3,5,2,-1,1,2]", 8},
            new object[] {"[-2,5,-4,1,-2,3,2,null,null,4]", 8},
            new object[] {"[2,5,-4,1,-2,3,2,null,null,4]", 9},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string treeStr, int expected)
        {
            var root = TreeNodeHelper.BuildTree(treeStr);

            var sol = new Solution();
            var res = sol.MaxPathSum(root);
            
            ClassicAssert.AreEqual(expected, res);
        }
    }
}