using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace PalindromeLinkedList
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1]", true},
            new object[] {"[1,2]", false},
            new object[] {"[1,2,2,1]", true},
            new object[] {"[1,2,3,2,1]", true},
            new object[] {"[1,2,3,3,2,1]", true},
            new object[] {"[1,2,3,4,3,2,1]", true},
            new object[] {"[1,1]", true},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string listStr, bool expected)
        {
            var head = ListNodeHelper.BuildList(listStr);

            var sol = new Solution();
            var res = sol.IsPalindrome(head);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}