using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace RemoveNthNodeFromEndOfList
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "[]", 1, "[]"},
            new object[] { "[1]", 1, "[]"},
            new object[] { "[1,2]", 1, "[1]"},
            new object[] { "[1,2,3,4,5]", 1, "[1,2,3,4]"},
            new object[] { "[1,2,3,4,5]", 2, "[1,2,3,5]"},
            new object[] { "[1,2,3,4,5]", 3, "[1,2,4,5]"},
            new object[] { "[1,2,3,4,5]", 4, "[1,3,4,5]"},
            new object[] { "[1,2,3,4,5]", 5, "[2,3,4,5]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic_2022(string listStr, int n, string expectedStr)
        {
            var head = ListNodeHelper.BuildList(listStr);
            var expected = ListNodeHelper.BuildList(expectedStr);

            var sol = new Solution_2022();
            var res = sol.RemoveNthFromEnd(head, n);

            Assert.That(ListNodeHelper.AreEqual(expected, res));
        }
        
        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string listStr, int n, string expectedStr)
        {
            var head = ListNodeHelper.BuildList(listStr);
            var expected = ListNodeHelper.BuildList(expectedStr);

            var sol = new Solution_2022();
            var res = sol.RemoveNthFromEnd(head, n);

            Assert.That(ListNodeHelper.AreEqual(expected, res));
        }
    }
}