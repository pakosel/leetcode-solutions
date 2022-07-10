using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SumRootToLeafNumbers
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1]", 1},
            new object[] {"[1,2,3]", 25},
            new object[] {"[0,2,3]", 5},
            new object[] {"[4,9,0,5,1]", 1026},
            new object[] {"[3,5,1,6,2,0,8,null,null,7,4,9,8]", 13942},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string strArr, int expected)
        {
            var root = TreeNodeHelper.BuildTree(strArr);

            var sol = new Solution();
            var res = sol.SumNumbers(root);
            
            Assert.AreEqual(expected, res);
        }
    }
}