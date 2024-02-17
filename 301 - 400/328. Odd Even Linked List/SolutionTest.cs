using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace OddEvenLinkedList
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[]", "[]" },
            new object[] {"[1]", "[1]" },
            new object[] {"[3]", "[3]" },
            new object[] {"[1,2]", "[1,2]" },
            new object[] {"[1,2,3]", "[1,3,2]" },
            new object[] {"[1,2,3,4]", "[1,3,2,4]" },
            new object[] {"[1,2,3,4,5]", "[1,3,5,2,4]" },
            new object[] {"[1,2,3,4,5,6]", "[1,3,5,2,4,6]" },
            new object[] {"[2,1,3,5,6,4,7]", "[2,3,6,7,1,5,4]" },
            new object[] {"[2,3,2,3,2]", "[2,2,2,3,3]" },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Stack(string listStr, string expectedStr)
        {
            var head = ListNodeHelper.BuildList(listStr);

            var sol = new Solution();
            var res = sol.OddEvenList(head);
            
            var expected = ListNodeHelper.BuildList(expectedStr);

            Assert.That(ListNodeHelper.AreEqual(res, expected));
        }
    }
}