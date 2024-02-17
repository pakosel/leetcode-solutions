using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;
using System;

namespace ValidateBinaryTreeNodes
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {4, "[1,-1,3,-1]", "[2,-1,-1,-1]", true},
            new object[] {4, "[1,-1,3,-1]", "[2,3,-1,-1]", false},
            new object[] {2, "[1,0]", "[-1,-1]", false},
            new object[] {4, "[-1,-1,0,1]", "[-1,-1,-1,2]", true},
            new object[] {4, "[1,-1,3,-1]", "[-1,-1,-1,-1]", false},
            new object[] {4, "[1,0,3,-1]", "[-1,-1,-1,-1]", false},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(int n, string leftChildStr, string rightChildStr, bool expected)
        {
            var leftChild = ArrayHelper.ArrayFromString<int>(leftChildStr);
            var rightChild = ArrayHelper.ArrayFromString<int>(rightChildStr);

            var sol = new Solution();
            var res = sol.ValidateBinaryTreeNodes(n, leftChild, rightChild);

            Assert.That(expected == res);
        }
    }
}