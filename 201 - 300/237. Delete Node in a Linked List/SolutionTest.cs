using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace DeleteNodeInLinkedList
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[4,5,1,9]", 5, "[4,1,9]"},
            new object[] {"[4,5,1,9]", 1, "[4,5,9]"},
            new object[] {"[4,5,1,9,11,3]", 4, "[5,1,9,11,3]"},
            new object[] {"[4,5,1,9,11,3]", 5, "[4,1,9,11,3]"},
            new object[] {"[4,5,1,9,11,3]", 1, "[4,5,9,11,3]"},
            new object[] {"[4,5,1,9,11,3]", 11, "[4,5,1,9,3]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string listStr, int nodeVal, string expectedStr)
        {
            var head = ListNodeHelper.BuildList(listStr);
            var expected = ListNodeHelper.BuildList(expectedStr);
            ListNode node = head;
            while(node?.val != nodeVal)
                node = node.next;
            
            ClassicAssert.IsNotNull(node);
            ClassicAssert.IsNotNull(node.next);

            var sol = new Solution();
            sol.DeleteNode(node);

            ClassicAssert.IsTrue(ListNodeHelper.AreEqual(expected, head));
        }
    }
}