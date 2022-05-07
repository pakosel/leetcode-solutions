using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ReorderList
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "[1]", "[1]"},
            new object[] { "[1,2]", "[1,2]"},
            new object[] { "[1,2,3]", "[1,3,2]"},
            new object[] { "[1,2,3,4]", "[1,4,2,3]"},
            new object[] { "[1,2,3,4,5]", "[1,5,2,4,3]"},
            new object[] { "[1,2,3,4,5,6]", "[1,6,2,5,3,4]"},
            new object[] { "[1,2,3,4,5,6,7]", "[1,7,2,6,3,5,4]"},
            new object[] { "[1,2,3,4,5,6,7,8]", "[1,8,2,7,3,6,4,5]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string inputStr, string expectedStr)
        {
            var head = ListNodeHelper.BuildList(inputStr);
            var expected = ListNodeHelper.BuildList(expectedStr);

            var sol = new Solution();
            sol.ReorderList(head);

            Assert.IsTrue(ListNodeHelper.AreEqual(head, expected));
        }
    }
}