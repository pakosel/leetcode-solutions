using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace RemoveNthNodeFromEndOfList
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { new ListNode(1) { next = new ListNode(2) { next = new ListNode(3) { next = new ListNode(4) { next = new ListNode(5) }}}}, 1, new ListNode(1) { next = new ListNode(2) { next = new ListNode(3) { next = new ListNode(4) }}}},
            new object[] { new ListNode(1) { next = new ListNode(2) { next = new ListNode(3) { next = new ListNode(4) { next = new ListNode(5) }}}}, 2, new ListNode(1) { next = new ListNode(2) { next = new ListNode(3) { next = new ListNode(5) }}}},
            new object[] { new ListNode(1) { next = new ListNode(2) { next = new ListNode(3) { next = new ListNode(4) { next = new ListNode(5) }}}}, 3, new ListNode(1) { next = new ListNode(2) { next = new ListNode(4) { next = new ListNode(5) }}}},
            new object[] { new ListNode(1) { next = new ListNode(2) { next = new ListNode(3) { next = new ListNode(4) { next = new ListNode(5) }}}}, 4, new ListNode(1) { next = new ListNode(3) { next = new ListNode(4) { next = new ListNode(5) }}}},
            new object[] { new ListNode(1) { next = new ListNode(2) { next = new ListNode(3) { next = new ListNode(4) { next = new ListNode(5) }}}}, 5, new ListNode(2) { next = new ListNode(3) { next = new ListNode(4) { next = new ListNode(5) }}}},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(ListNode head, int n, ListNode expected)
        {
            var sol = new Solution();
            var res = sol.RemoveNthFromEnd(head, n);

            while(res != null)
            {
                Assert.AreEqual(res.val, expected.val);
                res = res.next;
                expected = expected.next;
            }
            
            Assert.IsNull(expected);
        }
    }
}