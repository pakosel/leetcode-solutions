using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ReverseLinkedList
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "[]", "[]" },
            new object[] { "[1,2]", "[2,1]" },
            new object[] { "[1,2,3]", "[3,2,1]" },
            new object[] { "[1,2,3,4]", "[4,3,2,1]" },
            new object[] { "[1,2,3,4,5]", "[5,4,3,2,1]" },
            new object[] { "[1,2,3,4,5]", "[5,4,3,2,1]" },
            new object[] { "[1,2,3,4,5,6,7]", "[7,6,5,4,3,2,1]" },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string headStr, string expectedStr)
        {
            var head = ListNodeHelper.BuildList(headStr);
            var expected = ListNodeHelper.BuildList(expectedStr);

            var sol = new Solution();
            var res = sol.ReverseList(head);

            Assert.That(ListNodeHelper.AreEqual(res, expected), Is.True);
        }
    }
}