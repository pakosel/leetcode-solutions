using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace NextGreaterNodeInLinkedList
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { new ListNode(1), new int[] { 0 } },
            new object[] { new ListNode(2) { next = new ListNode(1) { next = new ListNode(5)}}, new int[] { 5,5,0 } },
            new object[] { new ListNode(2) { next = new ListNode(7) { next = new ListNode(4) { next = new ListNode(3) { next = new ListNode(5)}}}}, new int[] { 7,0,5,5,0 } },
            new object[] { new ListNode(1) { next = new ListNode(7) { next = new ListNode(5) { next = new ListNode(1) { next = new ListNode(9) {next = new ListNode(2) { next = new ListNode(5) { next = new ListNode(1)}}}}}}}, new int[] { 7,9,9,9,0,5,0,0 } },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(ListNode head, int[] expected)
        {
            var sol = new Solution();
            var res = sol.NextLargerNodes(head);

            Assert.That(res, Is.EqualTo(expected));
        }
    }
}