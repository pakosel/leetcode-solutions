using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace DeleteTheMiddleNodeOfLinkedList
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "[1]", "[]"},
            new object[] { "[1,2]", "[1]"},
            new object[] { "[1,2,3]", "[1,3]"},
            new object[] { "[1,2,3,4]", "[1,2,4]"},
            new object[] { "[1,2,3,4,5]", "[1,2,4,5]"},
            new object[] { "[1,2,3,4,5,6]", "[1,2,3,5,6]"},
            new object[] { "[1,2,3,4,5,6,7]", "[1,2,3,5,6,7]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string inputStr, string expectedStr)
        {
            var head = ListNodeHelper.BuildList(inputStr);
            var expected = ListNodeHelper.BuildList(expectedStr);

            var sol = new Solution();
            var res = sol.DeleteMiddle(head);

            Assert.IsTrue(ListNodeHelper.AreEqual(res, expected));
        }
    }
}