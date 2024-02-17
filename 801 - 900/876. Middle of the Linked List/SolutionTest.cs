using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MiddleOfTheLinkedList
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1]", "[1]"},
            new object[] {"[1,2,3,4,5]", "[3,4,5]"},
            new object[] {"[1,2,3,4,5,6]", "[4,5,6]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string listStr, string expectedStr)
        {
            var head = ListNodeHelper.BuildList(listStr);
            var expected = ListNodeHelper.BuildList(expectedStr);

            var sol = new Solution();
            var res = sol.MiddleNode(head);

            Assert.That(ListNodeHelper.AreEqual(res, expected));
        }
    }
}